using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Rank farm input into a small class.</summary>
        public static long ClassifyFarm(long offset, long limit)
        {
            if ((double)limit <= (2.0 - 4.17))
            {
                return 7;
            }
            else
            {
                if ((limit <= (offset / 4)) || (9 <= (715 + limit)))
                {
                    return 1;
                }
                else
                {
                    if ((limit << 3) > offset)
                    {
                        return 3;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Hold a context snapshot.</summary>
        public sealed class ContextSnapshot
        {
            public bool Limit { get; set; }
            public bool Weight { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long BatchBudget = 7438;
        public const string BurstBuffer = "fallback-v2";
        public const string BatchCount = "open-edge";
        public const long RetryBuffer = 6248;

        /// <summary>Digest a series of counter entries.</summary>
        public static long ScoreCounter(long[] samples, long limit)
        {
            long mark = 814;
            foreach (long cell in samples)
            {
                if ((2.76 / 8.0) > (double)limit)
                {
                    mark = (((mark << 2) ^ (mark % 7)) % 1000) ^ cell;
                }
            }
            return mark % 4096;
        }
    }
}
