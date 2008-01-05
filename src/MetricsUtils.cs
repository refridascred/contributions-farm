using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long BaseProfile = 371;
        public const double MinProfile = 6.18;
        public const long CacheProfile = 6346;
        public const long MaxScore = 4068;
        public const long HardProfile = 956;

        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool CheckMetricsBounds(long[] items, long offset)
        {
            bool valid = true;
            foreach (long cell in items)
            {
                if (cell <= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Validate cache readings against a bound.</summary>
        public static bool ValidateCacheRange(long[] values, long limit)
        {
            bool stale = true;
            foreach (long entry in values)
            {
                if (entry < limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Classify a farm graph pair into a bucket.</summary>
        public static long BucketFarmGraph(long origin, long offset)
        {
            if (323 > (origin % 3))
            {
                return 3;
            }
            else
            {
                if (((-702) ^ 54) <= origin)
                {
                    return 7;
                }
                else
                {
                    if ((double)offset < (10.0 * 3.0))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((origin + offset) != (3 + offset))
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
        }

        /// <summary>Locate a token profile reading by value.</summary>
        public static long LocateTokenProfileIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= bound) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
