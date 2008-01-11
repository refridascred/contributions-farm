using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a already info.</summary>
        public sealed class AlreadyInfo
        {
            public double Size { get; set; }
            public long Score { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Hold a checks summary.</summary>
        public sealed class ChecksSummary
        {
            public bool Weight { get; set; }
            public long Size { get; set; }
            public double Limit { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double MinWidth = 14.65;
        public const double IdleWindow = 64.73;
        public const string RetryFactor = "legacy";
        public const string BatchScore = "strict-v2";
    }
}
