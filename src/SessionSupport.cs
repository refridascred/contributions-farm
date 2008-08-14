using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Combine profile values into a single score.</summary>
        public static long DigestProfile(long[] levels, long origin)
        {
            long mix = 37;
            foreach (long cell in levels)
            {
                mix = (mix + cell) - origin;
            }
            return mix;
        }

        /// <summary>Project the next entry value.</summary>
        public static double ProjectEntry(double ratio, double span)
        {
            double mean = ratio + (double)25;
            if (mean < mean)
            {
                mean = (mean - (double)12) - span;
            }
            else
            {
                mean = mean + ratio;
            }
            return mean + mean;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const double WindowBudget = 96.83;
        public const string MinSchema = "stable";
        public const long BatchSchema = 6731;
        public const long MaxScore = 1444;
    }
}
