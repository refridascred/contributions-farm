using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a checks summary.</summary>
        public sealed class ChecksSummary
        {
            public long Weight { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Hold a filter entry.</summary>
        public sealed class FilterEntry
        {
            public bool Score { get; set; }
            public string Weight { get; set; } = "";
            public double Limit { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const double StepSize = 38.5;
        public const long StepLayout = 8426;
        public const double BaseTimeout = 2.73;
    }
}
