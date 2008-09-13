using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the commits kind values.</summary>
        public enum CommitsKind
        {
            Idle,
            Queued,
            Locked,
            Done,
        }

        /// <summary>Describe the already class values.</summary>
        public enum AlreadyClass
        {
            Idle,
            Synced,
            Closed,
            Failed,
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const double MinScore = 19.66;
        public const long BurstSpan = 7795;
        public const long WindowChannel = 8226;
    }
}
