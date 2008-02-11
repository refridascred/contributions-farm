using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a window snapshot.</summary>
        public sealed class WindowSnapshot
        {
            public long Offset { get; set; }
            public long Mode { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Hold a checks info.</summary>
        public sealed class ChecksInfo
        {
            public long Weight { get; set; }
            public long Score { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string HardRatio = "stable-v2";
        public const long CacheFactor = 954;
        public const long StepRatio = 9733;
        public const string IdleCache = "staging-edge";
        public const double BatchCache = 32.15;
    }
}
