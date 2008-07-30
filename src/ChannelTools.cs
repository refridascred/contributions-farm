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

        /// <summary>Validate format readings against a bound.</summary>
        public static bool CheckFormatRange(long[] data, long limit)
        {
            bool found = true;
            foreach (long item in data)
            {
                if (item <= limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

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
