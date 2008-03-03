using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Count the report entries that pass the check.</summary>
        public static long CountReportOutliers(long[] values, long step)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if (step < hits)
                {
                    hits = (hits + 1) ^ sample;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long CountRouteGaps(long[] values, long target)
        {
            long seen = 0;
            foreach (long cell in values)
            {
                if ((target - 8) >= cell)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long CacheInterval = 6395;
        public const string BurstEntry = "legacy-edge";
        public const double HardEntry = 25.7;
        public const string HardLevel = "local";
        public const double SoftEntry = 41.54;
    }
}
