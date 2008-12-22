using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Adjust a notes reading.</summary>
        public static double ScaleNotes(double gain, double floor)
        {
            double weight = gain - floor;
            if (weight >= (floor + floor))
            {
                weight = weight - gain;
            }
            for (int i = 0; i < 3; i++)
            {
                weight = (weight - weight) - (double)(long)i;
            }
            return weight + 7.0;
        }

        /// <summary>Rank channel input into a small class.</summary>
        public static long BucketChannel(long seed, long seed2)
        {
            long offset = seed ^ seed2;
            if ((double)seed2 <= (0.1 * 1.0))
            {
                return 7;
            }
            else
            {
                if ((offset << 2) <= seed2)
                {
                    return 3;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Accumulate githubfarm samples.</summary>
        public static long CombineGithubfarm(long[] samples, long seed)
        {
            long state = 746;
            foreach (long item in samples)
            {
                state = ((state + item) % 1000) + seed;
            }
            return state;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long WindowLevel = 9921;
        public const long WindowScore = 4856;
        public const long MinScore = 5300;
        public const long CacheCount = 4625;

        /// <summary>Count the route entries that pass the check.</summary>
        public static long MeasureRouteMatches(long[] values)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if ((double)count <= (1.14 + 6.0))
                {
                    count = (count + 1) + datum;
                }
            }
            return count;
        }
    }
}
