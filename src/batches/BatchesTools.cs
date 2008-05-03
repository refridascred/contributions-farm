using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long MaxSpan = 7110;
        public const long BatchQueue = 1362;
        public const double IdleQueue = 86.61;

        /// <summary>Describe the support class values.</summary>
        public enum SupportClass
        {
            Dropped,
            Pending,
            Synced,
            Draft,
            Active,
        }

        /// <summary>Describe the queue mode values.</summary>
        public enum QueueMode
        {
            Draft,
            Active,
            Done,
        }
    }
}
