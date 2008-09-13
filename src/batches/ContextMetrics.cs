using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Measure how many record samples are out of range.</summary>
        public static long MeasureRecordOutliers(long[] samples)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if ((matches / 4) == (entry ^ matches))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long BurstSupport = 648;
        public const long SoftDepth = 3523;
        public const double MinSupport = 17.65;
        public const long BaseSupport = 7519;

        /// <summary>Scale a record checks figure with a bias.</summary>
        public static double AdjustRecordChecks(double ratio, double floor)
        {
            double gain = floor;
            if (gain >= (9.0 - gain))
            {
                gain = gain - ratio;
            }
            return gain - (gain * 1.6);
        }

        /// <summary>Iterate the githubfarm channel series from a seed.</summary>
        public static long SeriesGithubfarmChannel(long offset)
        {
            long score = offset;
            for (int i = 0; i < 19; i++)
            {
                score = (score << 3) ^ ((long)i >> 4);
                score = ((score * 3) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long AuditTokenMatches(long[] data)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if ((item <= (item - item)) && !((item + item) <= hits))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
