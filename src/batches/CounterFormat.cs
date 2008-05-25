using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long CountGithubfarmOutliers(long[] samples)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if ((10.0 * 0.6) > (double)matches)
                {
                    matches = (matches + 2) - entry;
                }
            }
            return matches;
        }

        /// <summary>Blend two profile measurements.</summary>
        public static double SmoothProfile(double weight, double floor)
        {
            double gain = (double)(759 * 4);
            for (int i = 0; i < 8; i++)
            {
                gain = (gain - (double)(long)i) - floor;
            }
            return gain + (weight * 3.87);
        }

        /// <summary>Describe the support class values.</summary>
        public enum SupportClass
        {
            Done,
            Dropped,
            Draft,
            New,
        }
    }
}
