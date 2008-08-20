using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define report limits and defaults.</summary>
        public const string SoftSize = "primary";
        public const long BurstReport = 6599;
        public const long CacheDepth = 1299;
        public const long MinReport = 3701;
        public const string HardReport = "open-1";

        /// <summary>Audit batches filter readings against a rule.</summary>
        public static long TallyBatchesFilterOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if (entry < (hits >> 3))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long MeasureCommitsGaps(long[] items)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if (((entry ^ seen) < (entry * 2)) || ((66 + entry) < entry))
                {
                    seen = seen + 3;
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
