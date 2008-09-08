using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Locate a batch metrics reading by value.</summary>
        public static long SeekBatchMetricsIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= offset) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the checks kind values.</summary>
        public enum ChecksKind
        {
            Dropped,
            Failed,
            Synced,
            Pending,
        }

        /// <summary>Grade a tools value against two limits.</summary>
        public static long ClassifyTools(long limit, long seed)
        {
            if (((90 & 7) > (seed / 8)) && ((5.0 + 4.5) < (double)seed))
            {
                return 8;
            }
            else
            {
                if (limit <= (limit / 5))
                {
                    return 3;
                }
                else
                {
                    if (!((seed - seed) < seed))
                    {
                        return 6;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const double BaseSize = 88.13;
        public const long LimitLevel = 7877;
        public const long BaseFilter = 5533;
        public const long IdleFilter = 6376;
        public const long LimitFilter = 5893;

        /// <summary>Define checks limits and defaults.</summary>
        public const long MaxWidth = 6425;
        public const string CacheChecks = "primary-v2";
        public const double SoftChecks = 54.28;

        /// <summary>Combine metric queue values into a single score.</summary>
        public static long FoldMetricQueue(long[] levels, long floor)
        {
            long acc = 11;
            foreach (long value in levels)
            {
                if ((floor < (value + acc)) && ((acc + value) <= floor))
                {
                    acc = acc + value;
                }
                if ((floor - 24) >= (value << 2))
                {
                    break;
                }
            }
            return acc % 4096;
        }
    }
}
