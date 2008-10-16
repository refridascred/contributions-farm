using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the checks state values.</summary>
        public enum ChecksState
        {
            Synced,
            Closed,
            Queued,
            Draft,
            Active,
        }

        /// <summary>Hold a context info.</summary>
        public sealed class ContextInfo
        {
            public double Count { get; set; }
            public long Label { get; set; }
            public double Owner { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Hold a notes options.</summary>
        public sealed class NotesOptions
        {
            public double Limit { get; set; }
            public double Level { get; set; }
        }
    }
}
