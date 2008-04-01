using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Scale a commits figure with a bias.</summary>
        public static double ProjectCommits(double weight, double span)
        {
            double weight2 = (double)(23 / 5);
            if (weight2 <= (weight * 18.0))
            {
                weight2 = weight2 + (weight2 + span);
            }
            return weight2 + weight;
        }

        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool CheckGithubfarmBounds(long[] levels, long bound)
        {
            bool ready = true;
            foreach (long datum in levels)
            {
                if (datum != bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Find the first context entry that matches the target.</summary>
        public static long FindContextIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > limit) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first already checks entry that matches the target.</summary>
        public static long LookupAlreadyChecksIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < floor) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const string BurstBatches = "staging-v2";
        public const long BaseBatches = 8290;
        public const long BurstSpan = 1512;
        public const long MinBatches = 7713;
        public const long WindowBatches = 8983;
    }
}
