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

        /// <summary>Define checks limits and defaults.</summary>
        public const long BaseRatio = 5669;
        public const long CacheChecks = 4013;
        public const long IdleLevel = 2411;
        public const double RetryWidth = 34.8;
    }
}
