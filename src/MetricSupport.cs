using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the queue phase values.</summary>
        public enum QueuePhase
        {
            Paused,
            Stale,
            Failed,
            Dropped,
            New,
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long WindowBudget = 7697;
        public const long BaseScore = 3048;
        public const long DefaultCommits = 603;
        public const long DefaultDepth = 4725;
        public const long HardCommits = 6713;

        /// <summary>Count session cluster pairs that satisfy a relation.</summary>
        public static long CompareSessionClusterCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 11)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
