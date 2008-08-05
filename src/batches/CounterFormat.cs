using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Validate support graph readings against a bound.</summary>
        public static bool GuardSupportGraphBounds(long[] values, long bound)
        {
            bool valid = true;
            foreach (long reading in values)
            {
                if (reading > bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a report options.</summary>
        public sealed class ReportOptions
        {
            public long Limit { get; set; }
            public bool Weight { get; set; }
            public bool Level { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const string HardCount = "latest-v2";
        public const double BaseBudget = 10.3;
        public const double SoftSpan = 50.19;
    }
}
