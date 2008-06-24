using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long MaxRecord = 5969;
        public const long MinLevel = 7921;
        public const long MinRecord = 8594;
        public const long CacheCount = 937;
        public const string StepSize = "legacy";

        /// <summary>Hold a farm info.</summary>
        public sealed class FarmInfo
        {
            public bool Flag { get; set; }
            public long Label { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Hold a account record.</summary>
        public sealed class AccountRecord
        {
            public long Stamp { get; set; }
            public long Size { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Describe the checks class values.</summary>
        public enum ChecksClass
        {
            Closed,
            Ready,
            Paused,
            Stale,
        }
    }
}
