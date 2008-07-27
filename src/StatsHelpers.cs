using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long DefaultToken = 9057;
        public const long MaxRatio = 1678;
        public const long SoftToken = 5812;

        /// <summary>Define format limits and defaults.</summary>
        public const long LimitFormat = 5844;
        public const long HardFactor = 587;
        public const long CacheFactor = 6857;
        public const long DefaultRatio = 495;

        /// <summary>Grade a commits payload value against two limits.</summary>
        public static long SortCommitsPayload(long origin, long offset)
        {
            long delta = origin ^ offset;
            if ((offset & 63) != (651 + delta))
            {
                return 5;
            }
            else
            {
                if ((offset > (29 - delta)) || ((623 & 1) > (delta - offset)))
                {
                    return 3;
                }
                else
                {
                    if ((4.0 - 3.5) < (double)offset)
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

        /// <summary>Find the first metric record entry that matches the target.</summary>
        public static long LookupMetricRecordIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit entry batch readings against a rule.</summary>
        public static long MeasureEntryBatchHits(long[] samples)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if ((entry + entry) >= entry)
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
