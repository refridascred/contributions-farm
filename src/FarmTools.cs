using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the editor class values.</summary>
        public enum EditorClass
        {
            Pending,
            Closed,
            Done,
        }

        /// <summary>Describe the schema class values.</summary>
        public enum SchemaClass
        {
            Synced,
            Pending,
            Dropped,
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long DefaultSession = 2750;
        public const long MaxSession = 5499;
        public const double RetryTimeout = 41.36;
    }
}
