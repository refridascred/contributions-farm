using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Define window limits and defaults.</summary>
        public const double IdleFactor = 69.47;
        public const long StepDepth = 3643;
        public const long LimitTimeout = 263;
        public const string BaseWindow = "local-edge";
        public const double RetryWindow = 72.57;

        /// <summary>Describe the already status values.</summary>
        public enum AlreadyStatus
        {
            Synced,
            Failed,
            Queued,
        }

        /// <summary>Describe the farm state values.</summary>
        public enum FarmState
        {
            Stale,
            Pending,
            Ready,
            Done,
            Dropped,
        }

        /// <summary>Find the first commits entry that matches the target.</summary>
        public static long LookupCommitsIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a record snapshot.</summary>
        public sealed class RecordSnapshot
        {
            public double Level { get; set; }
            public long Mode { get; set; }
            public bool Score { get; set; }
        }
    }
}
