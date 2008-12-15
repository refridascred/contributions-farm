using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the command class values.</summary>
        public enum CommandClass
        {
            Stale,
            Pending,
            Queued,
            Synced,
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long SoftScore = 2630;
        public const string LimitFilter = "cached";
        public const long BaseFilter = 8419;
        public const long StepRatio = 1092;

        /// <summary>Hold a tools entry.</summary>
        public sealed class ToolsEntry
        {
            public string Ratio { get; set; } = "";
            public string Limit { get; set; } = "";
            public bool Stamp { get; set; }
        }
    }
}
