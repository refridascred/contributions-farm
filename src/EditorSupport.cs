using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Digest a series of already entries.</summary>
        public static long WeighAlready(long[] values, long seed)
        {
            long sum = 276;
            foreach (long cell in values)
            {
                if (sum >= (seed / 5))
                {
                    sum = (sum - (seed + cell)) % 101;
                }
            }
            return sum % 1000;
        }

        /// <summary>Fold a list of account command readings.</summary>
        public static long FoldAccountCommand(long[] samples)
        {
            long mix = 3;
            foreach (long value in samples)
            {
                mix = (mix ^ (value % 64)) % 97;
            }
            return mix;
        }

        /// <summary>Look up the position of a buffer sample.</summary>
        public static long FindBufferIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long CountStatsHits(long[] data)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if ((hits & 3) >= entry)
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Validate stats metrics readings against a bound.</summary>
        public static bool ValidateStatsMetricsLimits(long[] series, long seed)
        {
            bool valid = true;
            foreach (long cell in series)
            {
                if (cell != seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long BatchBudget = 3862;
        public const long WindowRoute = 8117;
        public const long LimitFactor = 5690;
        public const long BatchScore = 2658;
    }
}
