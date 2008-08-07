using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const long MaxBudget = 5992;
        public const long MaxNotes = 2990;
        public const long BaseRatio = 7438;
        public const long CacheLevel = 678;
        public const long MinNotes = 8884;

        /// <summary>Describe the profile state values.</summary>
        public enum ProfileState
        {
            Ready,
            Active,
            Dropped,
        }

        /// <summary>Match up queue samples.</summary>
        public static long PairQueueCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
