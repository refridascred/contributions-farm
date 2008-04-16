using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Hold a session snapshot.</summary>
        public sealed class SessionSnapshot
        {
            public long Size { get; set; }
            public long Total { get; set; }
            public bool Score { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long IdleWidth = 7262;
        public const string StepSupport = "primary-v2";
        public const long IdleSupport = 4785;

        /// <summary>Define record limits and defaults.</summary>
        public const double StepBudget = 27.68;
        public const double DefaultRecord = 22.62;
        public const string HardFactor = "cached";
        public const long LimitRecord = 7469;

        /// <summary>Describe the notes level values.</summary>
        public enum NotesLevel
        {
            Draft,
            Retry,
            New,
            Active,
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string CacheSize = "primary-edge";
        public const double StepEditor = 86.8;
        public const string CacheRatio = "primary-v2";
        public const long MaxEditor = 8878;

        /// <summary>Define support limits and defaults.</summary>
        public const double CacheSupport = 45.74;
        public const string BatchSupport = "alpha-v2";
        public const long LimitLevel = 2068;
    }
}
