using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Hold a filter header.</summary>
        public sealed class FilterHeader
        {
            public double Ratio { get; set; }
            public long Token { get; set; }
            public long Mode { get; set; }
            public string Level { get; set; } = "";
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

        /// <summary>Describe the payload level values.</summary>
        public enum PayloadLevel
        {
            Paused,
            Ready,
            Queued,
            Retry,
            New,
        }
    }
}
