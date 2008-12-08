using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the schema mode values.</summary>
        public enum SchemaMode
        {
            Failed,
            Stale,
            Locked,
        }

        /// <summary>Describe the format status values.</summary>
        public enum FormatStatus
        {
            Closed,
            New,
            Failed,
            Dropped,
            Idle,
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const double StepSpan = 23.86;
        public const long BatchStats = 8265;
        public const long StepStats = 6051;
    }
}
