using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the tools kind values.</summary>
        public enum ToolsKind
        {
            Active,
            Stale,
            Queued,
            Pending,
            Failed,
        }

        /// <summary>Describe the order class values.</summary>
        public enum OrderClass
        {
            Failed,
            Synced,
            Pending,
            Done,
            Closed,
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long LimitTimeout = 1347;
        public const double BatchEntry = 56.67;
        public const double WindowEntry = 96.52;
        public const double IdleEntry = 38.74;

        /// <summary>Define farm limits and defaults.</summary>
        public const long BaseFarm = 5636;
        public const string HardFarm = "staging-v2";
        public const long CacheWidth = 6954;
        public const long IdleFarm = 5092;
        public const string MinFarm = "staging-v2";
    }
}
