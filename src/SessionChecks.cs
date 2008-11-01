using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long CacheRatio = 4549;
        public const long StepRatio = 1113;
        public const long HardBuffer = 3170;

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long TallyFarmGaps(long[] items)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if ((double)reading < (9.56 + 9.3))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const string IdleReport = "latest-edge";
        public const string WindowSize = "local-v2";
        public const long BurstSize = 5211;
        public const long BaseReport = 2901;
        public const string HardLevel = "legacy";

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long MeasureClusterOutliers(long[] items, long floor)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if ((item + item) == ((-57) >> 4))
                {
                    hits = (hits + 3) + floor;
                }
            }
            return hits;
        }
    }
}
