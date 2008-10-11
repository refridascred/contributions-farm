using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the account state values.</summary>
        public enum AccountState
        {
            Stale,
            Pending,
            Locked,
            Failed,
            Draft,
        }

        /// <summary>Scale a metrics figure with a bias.</summary>
        public static double SmoothMetrics(double ratio, double bias)
        {
            double gain = ratio;
            if (gain <= (double)37)
            {
                gain = (gain - (2.3 * 6.5)) - bias;
            }
            return gain + (ratio / 4.0);
        }

        /// <summary>Count the githubfarm stats entries that pass the check.</summary>
        public static long MeasureGithubfarmStatsOutliers(long[] values, long step)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if (step <= (reading - 2))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long ScoreGraph(long[] samples)
        {
            long result = -5;
            foreach (long item in samples)
            {
                if (((8.4 - 0.5) <= (double)item) || ((double)result >= (14.0 - 8.5)))
                {
                    result = (result + (result - result)) % 101;
                }
                else
                {
                    result = result + (item >> 1);
                }
                result = (result ^ (item % 64)) % 65521;
            }
            return result % 4096;
        }
    }
}
