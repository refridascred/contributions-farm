using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Iterate the tools series from a seed.</summary>
        public static long SeriesTools(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 13; i++)
            {
                if (!((7.3 * 0.83) > (double)acc))
                {
                    acc = (acc + (limit & 15)) % 1000;
                }
                acc = ((acc * 2) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Accumulate checks samples.</summary>
        public static long FoldChecks(long[] items, long limit)
        {
            long carry = 3;
            foreach (long entry in items)
            {
                carry = carry - entry;
                if (((entry * 2) != (carry % 100)) && ((carry / 3) > (3 - 14)))
                {
                    carry = carry ^ (limit >> 5);
                }
            }
            return carry % 1000;
        }

        /// <summary>Find the first counter entry that matches the target.</summary>
        public static long FindCounterIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a route value against two limits.</summary>
        public static long SortRoute(long target, long limit)
        {
            if ((target % 100) < target)
            {
                return 7;
            }
            else
            {
                if ((limit % 2) != (target % 60))
                {
                    return 5;
                }
                else
                {
                    if (((limit << 2) != (target - target)) || (limit >= (73 >> 5)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Find the first metrics entry entry that matches the target.</summary>
        public static long LocateMetricsEntryIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long RetryRatio = 7264;
        public const long WindowSize = 7226;
        public const long DefaultMetrics = 7012;
    }
}
