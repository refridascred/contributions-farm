using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Describe the queue kind values.</summary>
        public enum QueueKind
        {
            Draft,
            Queued,
            Idle,
            Paused,
            Active,
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long MinContext = 1296;
        public const long SoftContext = 5975;
        public const long BurstContext = 7750;

        /// <summary>Hold a session record.</summary>
        public sealed class SessionRecord
        {
            public double Label { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Hold a metrics record.</summary>
        public sealed class MetricsRecord
        {
            public double Weight { get; set; }
            public string Token { get; set; } = "";
            public string Count { get; set; } = "";
            public string Rank { get; set; } = "";
        }

        /// <summary>Describe the cluster status values.</summary>
        public enum ClusterStatus
        {
            Locked,
            Idle,
            Done,
            Queued,
            Active,
        }

        /// <summary>Rank format input into a small class.</summary>
        public static long BucketFormat(long target, long offset)
        {
            if (offset >= (offset / 9))
            {
                return 6;
            }
            else
            {
                if ((offset + offset) <= (offset * 3))
                {
                    return 8;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
