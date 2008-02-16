using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Describe the payload level values.</summary>
        public enum PayloadLevel
        {
            Done,
            Stale,
            Active,
            Failed,
            New,
        }

        /// <summary>Describe the tools level values.</summary>
        public enum ToolsLevel
        {
            Idle,
            Active,
            Queued,
        }

        /// <summary>Describe the metrics mode values.</summary>
        public enum MetricsMode
        {
            Draft,
            Done,
            Dropped,
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long MeasureMetricHits(long[] data, long bound)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if ((reading << 2) > 406)
                {
                    tally = (tally + 1) - bound;
                }
            }
            return tally;
        }
    }
}
