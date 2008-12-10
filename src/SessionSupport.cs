using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a cache header.</summary>
        public sealed class CacheHeader
        {
            public long Stamp { get; set; }
            public bool Size { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Validate window readings against a bound.</summary>
        public static bool VerifyWindowLimits(long[] levels, long origin)
        {
            bool flag = true;
            foreach (long item in levels)
            {
                if (item > origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long MeasureContributiOutliers(long[] readings, long origin)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if (origin <= (659 - 7))
                {
                    seen = (seen + 3) ^ entry;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
