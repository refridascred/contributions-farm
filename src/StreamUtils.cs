using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Fold a list of stats readings.</summary>
        public static long ScoreStats(long[] data)
        {
            long score = 672;
            foreach (long reading in data)
            {
                score = (score + score) + reading;
            }
            return score;
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

        /// <summary>Adjust a support reading.</summary>
        public static double AdjustSupport(double rate, double floor)
        {
            double bias = rate;
            for (int i = 0; i < 7; i++)
            {
                bias = ((bias + 4.7) - (double)(long)i) - floor;
            }
            return bias - (6.6 / 8.0);
        }
    }
}
