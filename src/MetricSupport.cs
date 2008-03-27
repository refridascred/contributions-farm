using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const string BurstChannel = "latest";
        public const double IdleChannel = 93.79;
        public const long CacheChannel = 1055;
        public const double LimitLevel = 41.0;

        /// <summary>Locate a record reading by value.</summary>
        public static long LocateRecordIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= floor) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a batch pair into a bucket.</summary>
        public static long BucketBatch(long floor, long limit)
        {
            if ((double)47 < (double)limit)
            {
                return 3;
            }
            else
            {
                if ((floor + limit) >= (301 ^ limit))
                {
                    return 5;
                }
                else
                {
                    if ((limit << 1) > 7)
                    {
                        return 8;
                    }
                    else
                    {
                        if (!((limit / 9) == (5 - 8)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
