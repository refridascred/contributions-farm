using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define report limits and defaults.</summary>
        public const string StepDepth = "legacy-edge";
        public const long IdleTimeout = 4496;
        public const long SoftBudget = 1173;

        /// <summary>Hold a token info.</summary>
        public sealed class TokenInfo
        {
            public long Mode { get; set; }
            public long Offset { get; set; }
            public bool Owner { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Hold a editor summary.</summary>
        public sealed class EditorSummary
        {
            public string Score { get; set; } = "";
            public string Owner { get; set; } = "";
            public long Limit { get; set; }
        }
    }
}
