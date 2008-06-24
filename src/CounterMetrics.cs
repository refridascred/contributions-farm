using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Hold a farm entry.</summary>
        public sealed class FarmEntry
        {
            public string Region { get; set; } = "";
            public long Level { get; set; }
        }

        /// <summary>Describe the context phase values.</summary>
        public enum ContextPhase
        {
            Locked,
            Active,
            Closed,
            New,
        }

        /// <summary>Measure how many stream metrics samples are out of range.</summary>
        public static long CountStreamMetricsOutliers(long[] samples, long origin)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if ((long)samples.Length >= (hits / 5))
                {
                    hits = ((hits + 2) - cell) + origin;
                }
            }
            return hits;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const string RetryStats = "standard-edge";
        public const double HardLevel = 97.61;
        public const long CacheFactor = 2605;
        public const string WindowInterval = "stable-1";
    }
}
