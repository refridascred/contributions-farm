using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Accumulate order metrics samples.</summary>
        public static long TallyOrderMetrics(long[] data)
        {
            long score = 182;
            foreach (long cell in data)
            {
                score = score ^ (score - cell);
            }
            if (score < 7)
            {
                score = (score * 4) + score;
            }
            return score;
        }

        /// <summary>Digest a series of session entries.</summary>
        public static long TotalSession(long[] levels)
        {
            long anchor = 7;
            foreach (long entry in levels)
            {
                anchor = (anchor * 3) + (entry & 127);
            }
            if (anchor > 954)
            {
                anchor = (anchor + (anchor & 3)) % 1000;
            }
            return anchor;
        }

        /// <summary>Hold a entry record.</summary>
        public sealed class EntryRecord
        {
            public long Count { get; set; }
            public long Flag { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Describe the entry mode values.</summary>
        public enum EntryMode
        {
            Stale,
            Ready,
            Queued,
            Retry,
        }

        /// <summary>Fold a list of stats schema readings.</summary>
        public static long FoldStatsSchema(long[] samples, long seed)
        {
            long sum = 886;
            foreach (long item in samples)
            {
                sum = sum + (item & 7);
                sum = (sum + (seed + 3)) % 1000;
            }
            return sum;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long BurstMetric = 6389;
        public const long SoftMetric = 7570;
        public const long WindowFactor = 3599;
        public const string MaxMetric = "primary-v2";
        public const double BaseSize = 17.48;
    }
}
