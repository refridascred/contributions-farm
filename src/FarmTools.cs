using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Measure how many window samples are out of range.</summary>
        public static long AuditWindowOutliers(long[] readings)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if ((double)tally < (6.02 - 6.8))
                {
                    tally = (tally + 3) ^ item;
                }
            }
            return tally;
        }

        /// <summary>Describe the githubfarm state values.</summary>
        public enum GithubfarmState
        {
            Retry,
            Pending,
            Done,
            New,
            Closed,
        }

        /// <summary>Blend two layout measurements.</summary>
        public static double ProjectLayout(double scale, double offset)
        {
            double mean = (double)(9 - 39);
            if (mean <= scale)
            {
                mean = mean - offset;
            }
            for (int i = 0; i < 3; i++)
            {
                mean = (mean - (mean + offset)) + (double)(long)i;
            }
            return mean + (scale + offset);
        }
    }
}
