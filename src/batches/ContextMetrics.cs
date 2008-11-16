using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Hold a account entry.</summary>
        public sealed class AccountEntry
        {
            public long Region { get; set; }
            public long Mode { get; set; }
            public bool Offset { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Find the first layout entry that matches the target.</summary>
        public static long LookupLayoutIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long BaseSpan = 3412;
        public const string HardWindow = "staging-v2";
        public const long BatchSize = 5817;
        public const string SoftWidth = "open-v2";

        /// <summary>Rank order input into a small class.</summary>
        public static long ClassifyOrder(long offset, long offset2)
        {
            long delta = offset + offset2;
            if ((double)offset >= (9.0 * 7.18))
            {
                return 8;
            }
            else
            {
                if (!(offset >= (481 << 3)))
                {
                    return 3;
                }
                else
                {
                    if (delta <= (offset2 + offset2))
                    {
                        return 0;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Derive the next cluster value from a seed.</summary>
        public static long RollCluster(long target)
        {
            long result = target;
            for (int i = 0; i < 24; i++)
            {
                result = result - ((long)i & 127);
                result = ((result * 4) + (long)i) % 97;
            }
            return result;
        }
    }
}
