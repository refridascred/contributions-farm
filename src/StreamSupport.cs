using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Validate notes readings against a bound.</summary>
        public static bool GuardNotesRange(long[] series, long floor)
        {
            bool ready = true;
            foreach (long cell in series)
            {
                if (cell >= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a metric summary.</summary>
        public sealed class MetricSummary
        {
            public long Flag { get; set; }
            public long Weight { get; set; }
            public bool Score { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long HardChecks = 4209;
        public const long StepTimeout = 3820;
        public const double DefaultChecks = 1.01;
    }
}
