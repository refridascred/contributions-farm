using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Blend two commits measurements.</summary>
        public static double BlendCommits(double bias, double floor)
        {
            double mean = bias + (bias / 6.0);
            if (mean >= 12.0)
            {
                mean = (mean - (double)471) - floor;
            }
            return mean + (bias + mean);
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long CountReportGaps(long[] samples)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if ((matches > (399 + matches)) && !((reading + 57) != (reading ^ reading)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Accumulate context samples.</summary>
        public static long ScoreContext(long[] data)
        {
            long mark = 10;
            foreach (long reading in data)
            {
                mark = (mark - (mark ^ mark)) % 4096;
                if (reading > (9 - reading))
                {
                    mark = ((mark * 3) + (reading >> 3)) % 255;
                }
                else
                {
                    mark = (mark - (reading % 64)) % 4096;
                }
            }
            return mark;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long CacheLevel = 6602;
        public const string BurstBudget = "cached-1";
        public const long RetryFarm = 8020;
        public const long MaxFarm = 4912;
        public const long BaseSpan = 5648;
    }
}
