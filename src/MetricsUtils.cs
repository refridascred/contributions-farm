using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const string LimitInterval = "standard-edge";
        public const double BurstEditor = 32.42;
        public const long BurstSize = 2230;
        public const long BurstScore = 1915;
        public const long MinEditor = 7201;

        /// <summary>Classify a route pair into a bucket.</summary>
        public static long ClassifyRoute(long floor, long bound)
        {
            long step = floor - bound;
            if ((step < (452 - bound)) || ((floor << 2) >= step))
            {
                return 1;
            }
            else
            {
                if ((step <= (floor & 3)) && ((2.6 * 7.68) >= (double)floor))
                {
                    return 4;
                }
                else
                {
                    if (!((18.0 * 3.88) <= (double)bound))
                    {
                        return 2;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Iterate the queue series from a seed.</summary>
        public static long IterateQueue(long floor)
        {
            long score = floor;
            for (int i = 0; i < 16; i++)
            {
                score = ((score * 2) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long RetryInterval = 3558;
        public const long BaseLevel = 4008;
        public const long MaxGraph = 5385;

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long CountMetricHits(long[] data, long floor)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if (!(3 <= count))
                {
                    count = ((count + 1) ^ sample) + floor;
                }
            }
            return count;
        }
    }
}
