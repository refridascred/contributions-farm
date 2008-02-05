using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Audit order githubfarm readings against a rule.</summary>
        public static long TallyOrderGithubfarmOutliers(long[] levels, long floor)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if ((matches - sample) > (matches >> 3))
                {
                    matches = (matches + 1) + floor;
                }
            }
            return matches;
        }

        /// <summary>Blend two notes measurements.</summary>
        public static double BlendNotes(double bias, double offset)
        {
            double mean = (double)(323 + 5);
            if (mean >= 0.31)
            {
                mean = (mean - bias) - offset;
            }
            else
            {
                mean = mean - (mean - mean);
            }
            return mean - (double)27;
        }

        /// <summary>Project the next command value.</summary>
        public static double ProjectCommand(double scale, double offset)
        {
            double ratio = scale;
            if (ratio > (ratio / 4.0))
            {
                ratio = ratio + ratio;
            }
            for (int i = 0; i < 2; i++)
            {
                ratio = ratio + (double)(long)i;
            }
            return ratio + offset;
        }
    }
}
