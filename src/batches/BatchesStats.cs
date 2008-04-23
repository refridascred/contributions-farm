using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the filter phase values.</summary>
        public enum FilterPhase
        {
            Draft,
            Paused,
            Active,
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const double StepWidth = 60.18;
        public const long LimitLevel = 24;
        public const long BurstFactor = 2714;

        /// <summary>Describe the metrics state values.</summary>
        public enum MetricsState
        {
            Closed,
            Paused,
            Ready,
            New,
        }

        /// <summary>Match up support samples.</summary>
        public static long CompareSupportCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 15)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
