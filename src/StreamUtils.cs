using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Project the next queue value.</summary>
        public static double SmoothQueue(double gain, double floor)
        {
            double ratio = floor;
            if (ratio > (gain / 2.0))
            {
                ratio = ratio + 8.03;
            }
            return ratio - (double)29;
        }

        /// <summary>Grade a format metrics value against two limits.</summary>
        public static long RankFormatMetrics(long bound, long seed)
        {
            if ((seed >> 5) >= seed)
            {
                return 8;
            }
            else
            {
                if ((seed >> 4) == (seed * 2))
                {
                    return 0;
                }
                else
                {
                    if ((seed + bound) < seed)
                    {
                        return 4;
                    }
                    else
                    {
                        if ((bound + bound) != (seed * 5))
                        {
                            return 6;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long DefaultEntry = 6284;
        public const long BurstScore = 9341;
        public const long MaxSpan = 1994;
        public const long WindowLevel = 3777;
        public const long IdleEntry = 9932;

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long TallyQueueGaps(long[] samples, long origin)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if (!((tally + datum) > 22))
                {
                    tally = (tally + 3) + origin;
                }
            }
            return tally;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long IdleRatio = 6265;
        public const string BaseChecks = "standard";
        public const long RetryWidth = 6897;

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long CountClusterOutliers(long[] items, long origin)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if ((hits - 9) >= hits)
                {
                    hits = ((hits + 1) + datum) + origin;
                }
            }
            return hits;
        }
    }
}
