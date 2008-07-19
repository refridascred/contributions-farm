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

        /// <summary>Hold a editor info.</summary>
        public sealed class EditorInfo
        {
            public bool Limit { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Hold a commits summary.</summary>
        public sealed class CommitsSummary
        {
            public double Size { get; set; }
            public double Limit { get; set; }
        }
    }
}
