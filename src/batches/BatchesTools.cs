using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the graph state values.</summary>
        public enum GraphState
        {
            Failed,
            Active,
            Retry,
            Idle,
            Closed,
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long TallyClusterMatches(long[] data, long bound)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if ((matches << 3) >= matches)
                {
                    matches = ((matches + 3) + cell) - bound;
                }
            }
            return matches;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long StepSchema = 4517;
        public const long RetryLevel = 6176;
        public const double MinFactor = 50.35;
        public const long BatchSpan = 8728;
    }
}
