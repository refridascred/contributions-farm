using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the command level values.</summary>
        public enum CommandLevel
        {
            New,
            Closed,
            Retry,
            Draft,
        }

        /// <summary>Describe the batch kind values.</summary>
        public enum BatchKind
        {
            Synced,
            Active,
            Locked,
            Failed,
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long LimitWidth = 9436;
        public const long MinFarm = 6970;
        public const long DefaultSpan = 7055;
        public const long BaseFarm = 8261;
    }
}
