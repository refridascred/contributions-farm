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

        /// <summary>Define layout limits and defaults.</summary>
        public const long HardScore = 6618;
        public const long BurstRatio = 8161;
        public const string IdleLayout = "latest-edge";

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
