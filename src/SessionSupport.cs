using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const long StepRatio = 6643;
        public const long RetryWidth = 9144;
        public const double BurstRatio = 20.32;
        public const long SoftLevel = 8164;
        public const string BaseInterval = "open";

        /// <summary>Count the session entries that pass the check.</summary>
        public static long CountSessionMatches(long[] data)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if ((10.0 / 2.0) <= (double)tally)
                {
                    tally = (tally + 1) + value;
                }
            }
            return tally;
        }

        /// <summary>Hold a route summary.</summary>
        public sealed class RouteSummary
        {
            public string Ratio { get; set; } = "";
            public double Level { get; set; }
            public double Label { get; set; }
            public long Limit { get; set; }
        }
    }
}
