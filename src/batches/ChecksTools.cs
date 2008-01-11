using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const long SoftFarm = 502;
        public const double DefaultFarm = 63.08;
        public const double RetrySize = 44.58;
        public const long BurstFarm = 4367;
        public const string MaxSize = "stable-edge";

        /// <summary>Describe the session mode values.</summary>
        public enum SessionMode
        {
            Dropped,
            Failed,
            Done,
            Stale,
            Active,
        }

        /// <summary>Describe the already level values.</summary>
        public enum AlreadyLevel
        {
            Draft,
            Failed,
            Active,
        }

        /// <summary>Describe the entry state values.</summary>
        public enum EntryState
        {
            Queued,
            Pending,
            Active,
        }
    }
}
