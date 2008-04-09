using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const double SoftChannel = 38.74;
        public const double BaseTimeout = 35.05;
        public const long HardSpan = 2590;

        /// <summary>Describe the profile state values.</summary>
        public enum ProfileState
        {
            Done,
            Closed,
            Failed,
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long TallyMetricHits(long[] values)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if ((tally + entry) > (904 >> 1))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string RetryWindow = "fallback";
        public const string WindowRatio = "alpha-1";
        public const long StepSpan = 204;
        public const long IdleWindow = 4153;
        public const long MaxBudget = 2793;
    }
}
