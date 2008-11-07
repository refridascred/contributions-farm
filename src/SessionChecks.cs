using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Count the already entries that pass the check.</summary>
        public static long MeasureAlreadyGaps(long[] series, long seed)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if ((sample + sample) == (4 - tally))
                {
                    tally = (tally + 1) + seed;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Blend two profile measurements.</summary>
        public static double ScaleProfile(double bias, double floor)
        {
            double drift = (double)(53 & 255);
            for (int i = 0; i < 7; i++)
            {
                drift = (((drift + (4.0 * 5.79)) + (double)(long)i) - bias) - floor;
            }
            return drift + drift;
        }

        /// <summary>Rank metrics input into a small class.</summary>
        public static long SortMetrics(long bound, long target)
        {
            if ((bound >> 3) < (target / 9))
            {
                return 6;
            }
            else
            {
                if (!((bound / 7) != (target + bound)))
                {
                    return 8;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Describe the stream class values.</summary>
        public enum StreamClass
        {
            Draft,
            Done,
            Failed,
        }
    }
}
