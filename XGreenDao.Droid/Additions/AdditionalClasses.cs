using System;
using Android.Runtime;

namespace Org.Greenrobot.Greendao.Internal
{
    partial class FastCursor
    {
        static IntPtr id_getExtras;
        public unsafe global::Android.OS.Bundle Extras
        {
            // Metadata.xml XPath method reference: path="/api/package[@name='org.greenrobot.greendao.internal']/class[@name='FastCursor']/method[@name='getExtras' and count(parameter)=0]"
            [Register("getExtras", "()Landroid/os/Bundle;", "GetGetExtrasHandler")]
            get
            {
                if (id_getExtras == IntPtr.Zero)
                    id_getExtras = JNIEnv.GetMethodID(class_ref, "getExtras", "()Landroid/os/Bundle;");
                try
                {
                    return global::Java.Lang.Object.GetObject<global::Android.OS.Bundle>(JNIEnv.CallObjectMethod(((global::Java.Lang.Object)this).Handle, id_getExtras), JniHandleOwnership.TransferLocalRef);
                }
                finally
                {
                }
            }
            set
            {
                throw new NotSupportedException();
            }
        }
    }
}

namespace Org.Greenrobot.Greendao.Query
{
    public partial class LazyList 
    {
        Java.Util.IListIterator Java.Util.IList.ListIterator()
        {
            return ListIterator();
        }
    }
}
