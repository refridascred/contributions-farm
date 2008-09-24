using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Locate a profile reading by value.</summary>
        public static long LocateProfileIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate window samples.</summary>
        public static long FoldWindow(long[] series)
        {
            long anchor = 16;
            foreach (long item in series)
            {
                anchor = ((anchor - (anchor & 3)) % 101) + item;
            }
            return anchor % 97;
        }

        /// <summary>Validate account readings against a bound.</summary>
        public static bool ValidateAccountLimits(long[] values, long target)
        {
            bool flag = true;
            foreach (long entry in values)
            {
                if (entry < target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
