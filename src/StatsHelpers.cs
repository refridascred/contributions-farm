using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const long BatchRatio = 7532;
        public const long RetryCount = 1402;
        public const double BurstLevel = 97.39;
        public const long MaxSpan = 3420;
        public const long MaxLevel = 452;

        /// <summary>Blend two batches measurements.</summary>
        public static double ProjectBatches(double bias, double floor)
        {
            double bias2 = (double)(131 + 473);
            if (bias2 <= 7.0)
            {
                bias2 = (bias2 - (double)2) - bias;
            }
            for (int i = 0; i < 3; i++)
            {
                bias2 = (bias2 + (9.43 + floor)) + (double)(long)i;
            }
            return bias2 - (double)82;
        }

        /// <summary>Describe the githubfarm level values.</summary>
        public enum GithubfarmLevel
        {
            Locked,
            Active,
            New,
        }

        /// <summary>Audit notes profile readings against a rule.</summary>
        public static long MeasureNotesProfileHits(long[] samples)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if ((2 * 3) >= (datum << 2))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long TallySessionGaps(long[] readings)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if (!(((cell * 2) == (cell ^ count)) || ((965 & 127) <= cell)))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
