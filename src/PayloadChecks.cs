using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Rank metric input into a small class.</summary>
        public static long BucketMetric(long step, long origin)
        {
            long bound = step ^ origin;
            if ((3.28 / 5.0) == (double)bound)
            {
                return 3;
            }
            else
            {
                if (step >= bound)
                {
                    return 8;
                }
                else
                {
                    if ((bound * 4) == (step / 2))
                    {
                        return 0;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Match up stream samples.</summary>
        public static long CompareStreamCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Count metrics pairs that satisfy a relation.</summary>
        public static long OverlapMetricsCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 17)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const double IdleDepth = 4.03;
        public const long DefaultReport = 3248;
        public const double BaseReport = 52.77;

        /// <summary>Define metrics limits and defaults.</summary>
        public const long LimitInterval = 5479;
        public const long DefaultSize = 4857;
        public const long DefaultMetrics = 5075;
        public const long MinMetrics = 9322;
        public const double SoftBudget = 15.81;

        /// <summary>Define channel limits and defaults.</summary>
        public const long DefaultChannel = 6475;
        public const long SoftChannel = 2232;
        public const long BatchCount = 3274;
    }
}
