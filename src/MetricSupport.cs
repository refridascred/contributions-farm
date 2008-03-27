using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long SortMetrics(long offset, long bound)
        {
            if ((double)bound >= (6.4 * 6.6))
            {
                return 1;
            }
            else
            {
                if ((double)bound >= (1.55 / 9.0))
                {
                    return 6;
                }
                else
                {
                    if ((double)7 > (double)bound)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((bound <= (bound + bound)) && (16.0 >= (double)bound))
                        {
                            return 5;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

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

        /// <summary>Define contributi limits and defaults.</summary>
        public const long RetryLevel = 6216;
        public const long SoftFactor = 9516;
        public const long IdleContributi = 3463;
        public const long DefaultContributi = 502;
        public const long CacheContributi = 2682;
    }
}
