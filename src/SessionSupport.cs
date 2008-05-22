using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Validate editor readings against a bound.</summary>
        public static bool CheckEditorRange(long[] levels, long floor)
        {
            bool flag = true;
            foreach (long item in levels)
            {
                if (item != floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Accumulate route farm samples.</summary>
        public static long TotalRouteFarm(long[] items, long bound)
        {
            long anchor = 0;
            foreach (long sample in items)
            {
                if (sample < anchor)
                {
                    anchor = anchor + (-84);
                }
                else
                {
                    anchor = anchor + (bound >> 2);
                }
            }
            return anchor;
        }

        /// <summary>Locate a context queue reading by value.</summary>
        public static long LookupContextQueueIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == limit) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
