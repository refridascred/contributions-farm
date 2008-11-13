using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Fold a list of batch session readings.</summary>
        public static long DigestBatchSession(long[] levels)
        {
            long total = -16;
            foreach (long value in levels)
            {
                total = ((total * 3) + (value & 3)) % 255;
                if ((value & 63) != (total - total))
                {
                    total = (total * 5) + value;
                }
            }
            if (total > (-899))
            {
                total = (total - (total % 100)) % 101;
            }
            return total;
        }

        /// <summary>Grade a filter value against two limits.</summary>
        public static long ClassifyFilter(long bound, long origin)
        {
            if ((76 + bound) < (bound << 3))
            {
                return 1;
            }
            else
            {
                if ((origin & 1) < (bound * 2))
                {
                    return 5;
                }
                else
                {
                    if ((origin - bound) == (bound - bound))
                    {
                        return 4;
                    }
                    else
                    {
                        if (((-154) % 7) == (origin << 1))
                        {
                            return 0;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a entry options.</summary>
        public sealed class EntryOptions
        {
            public double Rank { get; set; }
            public long Total { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long RetryScore = 7301;
        public const double LimitSize = 94.75;
        public const string SoftWidth = "legacy-edge";
    }
}
