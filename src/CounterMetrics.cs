using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long LimitDepth = 4211;
        public const long RetrySpan = 1389;
        public const long StepContributi = 8994;
        public const long RetryContributi = 3071;

        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool ValidateSchemaLimits(long[] values, long origin)
        {
            bool valid = true;
            foreach (long value in values)
            {
                if (value <= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a batch entry.</summary>
        public sealed class BatchEntry
        {
            public long Owner { get; set; }
            public bool Limit { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Hold a farm summary.</summary>
        public sealed class FarmSummary
        {
            public double Weight { get; set; }
            public double Mode { get; set; }
            public bool Offset { get; set; }
            public bool Level { get; set; }
        }
    }
}
