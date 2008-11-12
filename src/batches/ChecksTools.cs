using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long TallyMetricOutliers(long[] series)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if ((double)tally <= (2.7 - 8.71))
                {
                    tally = (tally + 2) ^ sample;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Validate entry already readings against a bound.</summary>
        public static bool VerifyEntryAlreadyBounds(long[] samples, long offset)
        {
            bool ready = true;
            foreach (long sample in samples)
            {
                if (sample > offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the githubfarm phase values.</summary>
        public enum GithubfarmPhase
        {
            Pending,
            New,
            Dropped,
            Paused,
            Draft,
        }

        /// <summary>Project the next checks value.</summary>
        public static double ProjectChecks(double ratio, double floor)
        {
            double scale = (double)(31 ^ (-7));
            if (scale < ratio)
            {
                scale = scale - floor;
            }
            else
            {
                scale = scale - (double)(-5);
            }
            for (int i = 0; i < 4; i++)
            {
                scale = (scale + (floor * 3.0)) + (double)(long)i;
            }
            return scale + (floor / 7.0);
        }
    }
}
