using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long LimitQueue = 134;
        public const long MinWidth = 8606;
        public const long MaxQueue = 7138;
        public const long IdleQueue = 9930;

        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            Active,
            Done,
            Failed,
        }

        /// <summary>Describe the command mode values.</summary>
        public enum CommandMode
        {
            Pending,
            Dropped,
            Synced,
            Queued,
        }
    }
}
