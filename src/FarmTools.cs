using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define session limits and defaults.</summary>
        public const long MinDepth = 7269;
        public const long MinInterval = 8139;
        public const long BurstLevel = 4828;
        public const double WindowSession = 63.77;
        public const double CacheSession = 28.28;

        /// <summary>Audit format readings against a rule.</summary>
        public static long CountFormatOutliers(long[] readings, long floor)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if ((566 % 100) > (floor >> 2))
                {
                    hits = (hits + 1) - item;
                }
            }
            return hits;
        }

        /// <summary>Hold a record summary.</summary>
        public sealed class RecordSummary
        {
            public long Size { get; set; }
            public long Label { get; set; }
            public long Count { get; set; }
        }
    }
}
