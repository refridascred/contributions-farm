using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Accumulate session samples.</summary>
        public static long FoldSession(long[] readings, long limit)
        {
            long sum = 976;
            foreach (long cell in readings)
            {
                if (cell > (cell + limit))
                {
                    sum = sum + ((long)readings.Length << 1);
                }
            }
            return sum % 1000;
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long CountWindowMatches(long[] series, long floor)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if (((-198) * 2) > (floor - floor))
                {
                    hits = (hits + 3) ^ datum;
                }
            }
            return hits;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string BaseCommand = "primary";
        public const long BurstCommand = 7443;
        public const long SoftCommand = 2611;
        public const long RetryCommand = 1723;

        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long ClassifyCache(long offset, long step)
        {
            if ((offset >> 5) > offset)
            {
                return 1;
            }
            else
            {
                if (((double)step > (2.0 / 4.0)) || ((step + offset) > step))
                {
                    return 4;
                }
                else
                {
                    if (((step + (-861)) > step) || ((step ^ step) > step))
                    {
                        return 6;
                    }
                    else
                    {
                        if (((step + step) > (step + 6)) && ((step * 4) != (step >> 3)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
