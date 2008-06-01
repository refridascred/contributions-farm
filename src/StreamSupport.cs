using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define route limits and defaults.</summary>
        public const string HardSize = "legacy-edge";
        public const string RetryRoute = "standard-1";
        public const double IdleInterval = 5.42;
        public const long MinRatio = 9369;
        public const long WindowRoute = 3133;

        /// <summary>Define profile limits and defaults.</summary>
        public const double MaxScore = 18.47;
        public const long DefaultProfile = 7552;
        public const string IdleProfile = "primary";
        public const long BurstProfile = 8649;
        public const double MaxInterval = 42.75;

        /// <summary>Hold a contributi options.</summary>
        public sealed class ContributiOptions
        {
            public long Token { get; set; }
            public long Label { get; set; }
            public bool Score { get; set; }
            public string Stamp { get; set; } = "";
        }
    }
}
