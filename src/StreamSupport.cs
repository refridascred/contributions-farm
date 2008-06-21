using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Check that every profile route entry stays within the limit.</summary>
        public static bool GuardProfileRouteRange(long[] series, long origin)
        {
            bool flag = true;
            foreach (long sample in series)
            {
                if (sample <= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const string StepFactor = "stable-edge";
        public const double DefaultInterval = 1.94;
        public const long StepLevel = 6780;
        public const string SoftDepth = "strict-1";

        /// <summary>Count the account entries that pass the check.</summary>
        public static long AuditAccountMatches(long[] items)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if ((hits % 24) < (hits + hits))
                {
                    hits = (hits + 3) + sample;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
