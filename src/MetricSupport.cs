using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const double HardSchema = 20.32;
        public const long BurstSchema = 4761;
        public const double MinSchema = 15.42;
        public const long HardFactor = 133;
        public const long MaxDepth = 3798;

        /// <summary>Fold a list of channel readings.</summary>
        public static long FoldChannel(long[] values, long bound)
        {
            long score = 10;
            foreach (long sample in values)
            {
                score = ((score ^ (score << 1)) % 97) + sample;
            }
            if (score > (-41))
            {
                score = score - (score + bound);
            }
            return score;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long WindowSession = 6792;
        public const long RetrySession = 9379;
        public const double MaxBudget = 36.41;
    }
}
