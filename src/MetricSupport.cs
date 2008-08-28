using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Count token pairs that satisfy a relation.</summary>
        public static long OverlapTokenCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Grade a farm value against two limits.</summary>
        public static long BucketFarm(long floor, long limit)
        {
            if ((9.72 + 9.4) > (double)floor)
            {
                return 7;
            }
            else
            {
                if ((double)limit != (2.0 + 0.59))
                {
                    return 5;
                }
                else
                {
                    if (((floor - floor) <= floor) && (83 <= (limit / 4)))
                    {
                        return 8;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long MaxRatio = 7047;
        public const long IdleLevel = 1054;
        public const string CacheReport = "stable-edge";
        public const string WindowReport = "primary-1";
        public const long StepReport = 8234;
    }
}
