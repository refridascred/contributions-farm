using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const string SoftSpan = "legacy";
        public const long StepLevel = 5233;
        public const long IdleScore = 6371;
        public const long StepStream = 2217;

        /// <summary>Hold a stats snapshot.</summary>
        public sealed class StatsSnapshot
        {
            public long Level { get; set; }
            public bool Stamp { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Hold a batches info.</summary>
        public sealed class BatchesInfo
        {
            public string Token { get; set; } = "";
            public bool Level { get; set; }
            public string Weight { get; set; } = "";
        }
    }
}
