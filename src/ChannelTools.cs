using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the payload kind values.</summary>
        public enum PayloadKind
        {
            Paused,
            Draft,
            Idle,
            Active,
            Pending,
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long MaxRatio = 2538;
        public const double SoftFilter = 68.02;
        public const string MaxFilter = "staging-1";

        /// <summary>Describe the tools status values.</summary>
        public enum ToolsStatus
        {
            Queued,
            Closed,
            Stale,
            Paused,
        }
    }
}
