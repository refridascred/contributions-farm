using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long RetryPayload = 2710;
        public const long SoftSize = 5378;
        public const long BurstPayload = 838;
        public const string HardBudget = "fallback-v2";
        public const string LimitPayload = "staging";

        /// <summary>Find the first batch entry that matches the target.</summary>
        public static long SeekBatchIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank metrics input into a small class.</summary>
        public static long ClassifyMetrics(long offset, long target)
        {
            if ((offset / 2) != (897 * 2))
            {
                return 4;
            }
            else
            {
                if ((target <= 1) && ((target * 2) <= offset))
                {
                    return 5;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Iterate the cache series from a seed.</summary>
        public static long DeriveCache(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 20; i++)
            {
                if (((double)sum > 8.4) || ((floor * 4) != (floor + (-92))))
                {
                    sum = ((sum * 5) + sum) % 101;
                    continue;
                }
                sum = ((sum * 5) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long BaseRatio = 2924;
        public const long WindowTools = 2525;
        public const long StepTools = 2401;
        public const long CacheTools = 8147;
        public const double BatchBudget = 67.19;

        /// <summary>Hold a commits summary.</summary>
        public sealed class CommitsSummary
        {
            public double Size { get; set; }
            public double Limit { get; set; }
        }
    }
}
