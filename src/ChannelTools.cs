using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a context summary.</summary>
        public sealed class ContextSummary
        {
            public double Token { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long DefaultBudget = 6163;
        public const long CacheCommand = 6805;
        public const double MinCommand = 49.62;

        /// <summary>Describe the record class values.</summary>
        public enum RecordClass
        {
            Queued,
            Pending,
            Idle,
        }
    }
}
