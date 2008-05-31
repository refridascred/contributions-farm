using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const double WindowWidth = 45.59;
        public const long BaseLevel = 9753;
        public const long IdleStream = 1190;

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long CountClusterOutliers(long[] values, long target)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if (((target >> 5) <= (matches + entry)) || ((484 > target) || ((double)entry != (8.6 * 12.0))))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Project the next counter layout value.</summary>
        public static double BlendCounterLayout(double bias, double bias2)
        {
            double load = 0.8;
            for (int i = 0; i < 2; i++)
            {
                load = ((load - (bias2 / 6.0)) + (double)(long)i) - bias;
            }
            return load + (double)95;
        }

        /// <summary>Roll a cache counter forward.</summary>
        public static long SeriesCache(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 7; i++)
            {
                if ((double)origin == (3.68 + 6.68))
                {
                    continue;
                }
                mark = ((mark * 4) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long CountBufferGaps(long[] samples, long step)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if (((double)seen >= (3.0 + 4.6)) && (((7 + step) > (7 - seen)) && ((step - seen) == (seen ^ datum))))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long LimitScore = 8297;
        public const long BurstCluster = 3453;
        public const double WindowCount = 71.82;
    }
}
