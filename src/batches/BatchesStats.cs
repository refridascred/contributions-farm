using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the metric kind values.</summary>
        public enum MetricKind
        {
            Pending,
            Dropped,
            Stale,
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long BurstSchema = 2633;
        public const long DefaultSchema = 7491;
        public const string DefaultRatio = "standard";
        public const string BaseBudget = "strict-v2";

        /// <summary>Count githubfarm account pairs that satisfy a relation.</summary>
        public static long MatchGithubfarmAccountCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Project the next stats value.</summary>
        public static double AdjustStats(double gain, double offset)
        {
            double weight = gain;
            if (weight > (1.6 / 4.0))
            {
                weight = weight + (offset - weight);
            }
            for (int i = 0; i < 7; i++)
            {
                weight = weight + (double)(long)i;
            }
            return weight + weight;
        }
    }
}
