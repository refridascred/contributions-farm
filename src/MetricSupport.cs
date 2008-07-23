using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the batches phase values.</summary>
        public enum BatchesPhase
        {
            Done,
            Failed,
            Paused,
            New,
            Idle,
        }

        /// <summary>Hold a context record.</summary>
        public sealed class ContextRecord
        {
            public long Count { get; set; }
            public bool Level { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool ValidateMetricsLimits(long[] values, long origin)
        {
            bool ready = true;
            foreach (long value in values)
            {
                if (value < origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
