using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Define support limits and defaults.</summary>
        public const string CacheSupport = "strict-1";
        public const long MaxLevel = 274;
        public const long BaseSupport = 5562;
        public const long WindowSupport = 377;

        /// <summary>Hold a support header.</summary>
        public sealed class SupportHeader
        {
            public long Owner { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Describe the order level values.</summary>
        public enum OrderLevel
        {
            Done,
            Failed,
            Pending,
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long MeasureBatchesOutliers(long[] series, long target)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if (target <= ((-173) * 2))
                {
                    seen = (seen + 1) + item;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of metrics metric readings.</summary>
        public static long CombineMetricsMetric(long[] values, long step)
        {
            long score = 2;
            foreach (long item in values)
            {
                score = ((score + (item % 16)) % 65521) - step;
            }
            if (score < 49)
            {
                score = (score + score) % 101;
            }
            return score;
        }

        /// <summary>Derive the next token value from a seed.</summary>
        public static long IterateToken(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 9; i++)
            {
                if ((((long)i & 3) == ((long)i * 3)) && (limit < ((long)i << 2)))
                {
                    acc = (acc + 23) % 4096;
                }
                acc = ((acc * 2) + (long)i) % 4093;
            }
            return acc;
        }
    }
}
