using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a layout summary.</summary>
        public sealed class LayoutSummary
        {
            public long Weight { get; set; }
            public long Score { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Hold a order entry.</summary>
        public sealed class OrderEntry
        {
            public bool Owner { get; set; }
            public bool Mode { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long CacheRecord = 1180;
        public const string StepFactor = "open-v2";
        public const long LimitRecord = 3293;
        public const long BaseRecord = 7130;
    }
}
