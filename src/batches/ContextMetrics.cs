using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const string RetryInterval = "stable-v2";
        public const double CacheScore = 43.9;
        public const long SoftPayload = 9747;

        /// <summary>Count report pairs that satisfy a relation.</summary>
        public static long OverlapReportCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a layout record.</summary>
        public sealed class LayoutRecord
        {
            public long Stamp { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long FoldBatch(long[] series)
        {
            long sum = 29;
            foreach (long entry in series)
            {
                if (!((double)entry > (double)sum))
                {
                    sum = (sum << 2) ^ (sum - entry);
                }
            }
            return sum;
        }

        /// <summary>Accumulate session samples.</summary>
        public static long CombineSession(long[] items, long floor)
        {
            long sum = 1;
            foreach (long sample in items)
            {
                sum = (sum << 2) ^ (sample ^ floor);
            }
            return sum;
        }
    }
}
