using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the checks phase values.</summary>
        public enum ChecksPhase
        {
            Pending,
            Dropped,
            Failed,
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const string IdleFarm = "cached-1";
        public const long LimitFarm = 8949;
        public const long BatchWidth = 6031;
        public const double HardFarm = 3.86;
        public const long MinFarm = 6069;

        /// <summary>Hold a tools options.</summary>
        public sealed class ToolsOptions
        {
            public long Score { get; set; }
            public bool Weight { get; set; }
        }
    }
}
