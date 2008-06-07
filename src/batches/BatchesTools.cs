using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the schema state values.</summary>
        public enum SchemaState
        {
            Done,
            Queued,
            Retry,
            Synced,
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string MaxRoute = "latest-1";
        public const double BaseRoute = 55.83;
        public const long MinFactor = 4775;

        /// <summary>Describe the format phase values.</summary>
        public enum FormatPhase
        {
            Done,
            Queued,
            Idle,
        }
    }
}
