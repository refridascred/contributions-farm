using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long BurstScore = 519;
        public const string DefaultQueue = "standard-1";
        public const long BatchQueue = 2821;

        /// <summary>Describe the cache level values.</summary>
        public enum CacheLevel
        {
            Dropped,
            Draft,
            Retry,
            Ready,
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long MeasureToolsGaps(long[] levels, long target)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if ((value << 3) < (tally * 2))
                {
                    tally = (tally + 3) - target;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Accumulate stats samples.</summary>
        public static long TallyStats(long[] series)
        {
            long total = 6;
            foreach (long entry in series)
            {
                total = (total ^ (entry + entry)) % 65521;
            }
            return total;
        }

        /// <summary>Hold a report entry.</summary>
        public sealed class ReportEntry
        {
            public long Mode { get; set; }
            public long Region { get; set; }
            public long Total { get; set; }
            public long Offset { get; set; }
        }
    }
}
