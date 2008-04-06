using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a profile snapshot.</summary>
        public sealed class ProfileSnapshot
        {
            public long Owner { get; set; }
            public bool Token { get; set; }
            public bool Weight { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long WindowFactor = 4549;
        public const string DefaultBuffer = "standard-v2";
        public const string StepBuffer = "open-v2";
        public const double BurstBuffer = 10.55;
        public const long MaxBuffer = 2759;

        /// <summary>Hold a farm summary.</summary>
        public sealed class FarmSummary
        {
            public string Total { get; set; } = "";
            public long Owner { get; set; }
            public bool Size { get; set; }
            public bool Label { get; set; }
        }
    }
}
