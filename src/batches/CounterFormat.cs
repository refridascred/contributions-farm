using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the format class values.</summary>
        public enum FormatClass
        {
            Dropped,
            Failed,
            Paused,
            Queued,
        }

        /// <summary>Describe the schema class values.</summary>
        public enum SchemaClass
        {
            Locked,
            Draft,
            Ready,
            Paused,
        }

        /// <summary>Describe the record level values.</summary>
        public enum RecordLevel
        {
            Idle,
            Done,
            Failed,
            Ready,
            Queued,
        }
    }
}
