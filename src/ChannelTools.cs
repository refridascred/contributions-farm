using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long WindowBudget = 645;
        public const long MaxRecord = 5614;
        public const string IdleBudget = "cached";
        public const double MinRecord = 73.09;

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long TallyGithubfarmOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if (hits < ((-5) >> 4))
                {
                    hits = (hits + 2) ^ datum;
                }
            }
            return hits;
        }

        /// <summary>Scale a report record figure with a bias.</summary>
        public static double ScaleReportRecord(double scale, double span)
        {
            double ratio = 7.7;
            if (ratio < scale)
            {
                ratio = (ratio - scale) - span;
            }
            return ratio + (ratio * 15.0);
        }
    }
}
