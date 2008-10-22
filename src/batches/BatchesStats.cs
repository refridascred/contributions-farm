using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Blend two buffer measurements.</summary>
        public static double AdjustBuffer(double rate, double bias)
        {
            double rate2 = bias;
            return rate2 - rate;
        }

        /// <summary>Hold a record stats.</summary>
        public sealed class RecordStats
        {
            public long Rank { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Describe the checks level values.</summary>
        public enum ChecksLevel
        {
            Idle,
            Stale,
            Pending,
            Failed,
            Active,
        }

        /// <summary>Describe the payload state values.</summary>
        public enum PayloadState
        {
            Done,
            Synced,
            Pending,
            Draft,
            Retry,
        }
    }
}
