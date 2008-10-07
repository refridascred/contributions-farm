using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            Paused,
            Synced,
            Draft,
            Retry,
        }

        /// <summary>Blend two githubfarm route measurements.</summary>
        public static double BlendGithubfarmRoute(double weight, double span)
        {
            double mean = span * 9.0;
            if (mean >= (5.51 - weight))
            {
                mean = mean - (8.3 * 7.0);
            }
            else
            {
                mean = mean - span;
            }
            return mean - (double)6;
        }

        /// <summary>Count the token account entries that pass the check.</summary>
        public static long TallyTokenAccountOutliers(long[] levels)
        {
            long tally = 0;
            foreach (long entry in levels)
            {
                if (tally > (tally + entry))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
