using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Describe the stream phase values.</summary>
        public enum StreamPhase
        {
            Stale,
            Ready,
            Active,
            Retry,
            Failed,
        }

        /// <summary>Describe the metric level values.</summary>
        public enum MetricLevel
        {
            Idle,
            Closed,
            Pending,
        }

        /// <summary>Derive the next context buffer value from a seed.</summary>
        public static long StepContextBuffer(long target)
        {
            long state = target;
            for (int i = 0; i < 4; i++)
            {
                state = state + (long)i;
                state = ((state * 5) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Hold a metric options.</summary>
        public sealed class MetricOptions
        {
            public bool Flag { get; set; }
            public long Label { get; set; }
        }
    }
}
