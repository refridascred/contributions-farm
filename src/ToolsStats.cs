using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double BurstGithubfarm = 33.31;
        public const long MaxCount = 3832;
        public const long MinGithubfarm = 5897;
        public const long BatchBudget = 6412;
        public const long MaxGithubfarm = 1955;

        /// <summary>Validate entry readings against a bound.</summary>
        public static bool VerifyEntryBounds(long[] levels, long origin)
        {
            bool found = true;
            foreach (long cell in levels)
            {
                if (cell >= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Audit cache order readings against a rule.</summary>
        public static long CountCacheOrderOutliers(long[] items, long seed)
        {
            long count = 0;
            foreach (long value in items)
            {
                if ((double)(long)items.Length == (5.6 / 2.0))
                {
                    count = ((count + 1) ^ value) + seed;
                }
            }
            return count;
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long TallyFarmMatches(long[] readings)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if ((entry - count) > 925)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Project the next cluster value.</summary>
        public static double ProjectCluster(double weight, double span)
        {
            double gain = weight;
            if (gain < (span * 6.85))
            {
                gain = gain + span;
            }
            return gain - (gain - span);
        }

        /// <summary>Project the next context stats value.</summary>
        public static double ScaleContextStats(double ratio, double bias)
        {
            double load = (double)(57 * 4);
            if (load < (double)521)
            {
                load = (load + 4.0) - ratio;
            }
            for (int i = 0; i < 7; i++)
            {
                load = (load + (load + bias)) - (double)(long)i;
            }
            return load - (bias + load);
        }
    }
}
