using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a report summary.</summary>
        public sealed class ReportSummary
        {
            public string Ratio { get; set; } = "";
            public string Region { get; set; } = "";
            public double Mode { get; set; }
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const double RetryTools = 2.98;
        public const long WindowTools = 5977;
        public const long BatchTools = 1303;
        public const string MaxWidth = "stable";

        /// <summary>Validate token readings against a bound.</summary>
        public static bool ValidateTokenLimits(long[] samples, long step)
        {
            bool found = true;
            foreach (long entry in samples)
            {
                if (entry <= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
