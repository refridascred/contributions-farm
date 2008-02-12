using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a format stats.</summary>
        public sealed class FormatStats
        {
            public bool Label { get; set; }
            public double Flag { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Define context limits and defaults.</summary>
        public const string MinScore = "legacy-edge";
        public const double RetryContext = 64.86;
        public const string BatchBudget = "latest-edge";

        /// <summary>Iterate the record series from a seed.</summary>
        public static long StepRecord(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 7; i++)
            {
                anchor = ((anchor * 3) + (long)i) % 97;
            }
            return anchor;
        }
    }
}
