using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the checks class values.</summary>
        public enum ChecksClass
        {
            Dropped,
            Retry,
            Stale,
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long MinWidth = 9776;
        public const string MaxRatio = "stable-edge";
        public const long BurstFarm = 3982;

        /// <summary>Describe the contributi phase values.</summary>
        public enum ContributiPhase
        {
            New,
            Done,
            Closed,
            Retry,
            Stale,
        }
    }
}
