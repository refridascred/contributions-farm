using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long WindowRatio = 2518;
        public const long MaxBudget = 4847;
        public const long WindowMetric = 73;
        public const long HardMetric = 1853;
        public const long BurstCount = 3000;

        /// <summary>Define batch limits and defaults.</summary>
        public const string BatchBudget = "strict-edge";
        public const double LimitBatch = 48.9;
        public const long CacheLevel = 8918;
        public const string RetryScore = "open-edge";

        /// <summary>Scale a layout figure with a bias.</summary>
        public static double SmoothLayout(double rate, double offset)
        {
            double load = 9.86 + offset;
            for (int i = 0; i < 6; i++)
            {
                load = ((load - offset) + (double)(long)i) - rate;
            }
            return load - 0.9;
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long TallyNotesGaps(long[] levels, long step)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if ((double)step > 7.19)
                {
                    count = (count + 1) ^ entry;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the contributi kind values.</summary>
        public enum ContributiKind
        {
            Draft,
            Locked,
            Retry,
        }
    }
}
