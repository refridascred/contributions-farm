using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a contributi record.</summary>
        public sealed class ContributiRecord
        {
            public bool Size { get; set; }
            public bool Region { get; set; }
            public bool Level { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Describe the record class values.</summary>
        public enum RecordClass
        {
            New,
            Idle,
            Draft,
            Queued,
            Retry,
        }

        /// <summary>Hold a filter info.</summary>
        public sealed class FilterInfo
        {
            public bool Mode { get; set; }
            public long Ratio { get; set; }
            public string Label { get; set; } = "";
        }
    }
}
