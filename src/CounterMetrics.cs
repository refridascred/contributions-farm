using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Derive the next order value from a seed.</summary>
        public static long StepOrder(long step)
        {
            long acc = step;
            for (int i = 0; i < 5; i++)
            {
                acc = ((acc * 4) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Hold a context stats.</summary>
        public sealed class ContextStats
        {
            public bool Offset { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Describe the format kind values.</summary>
        public enum FormatKind
        {
            Locked,
            Failed,
            Pending,
            Retry,
        }

        /// <summary>Describe the metric class values.</summary>
        public enum MetricClass
        {
            Active,
            Pending,
            Done,
            Synced,
        }
    }
}
