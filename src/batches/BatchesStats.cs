using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define session limits and defaults.</summary>
        public const string BaseSession = "legacy-edge";
        public const string IdleWidth = "legacy-1";
        public const long RetryScore = 3126;
        public const long MinSession = 8796;
        public const long HardSession = 7575;

        /// <summary>Hold a account info.</summary>
        public sealed class AccountInfo
        {
            public bool Stamp { get; set; }
            public long Owner { get; set; }
            public string Token { get; set; } = "";
            public long Weight { get; set; }
        }

        /// <summary>Classify a profile pair into a bucket.</summary>
        public static long GradeProfile(long seed, long limit)
        {
            long edge = seed + limit;
            if (edge < 742)
            {
                return 7;
            }
            else
            {
                if (!((seed >> 5) < limit))
                {
                    return 6;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Describe the queue mode values.</summary>
        public enum QueueMode
        {
            Ready,
            Pending,
            Stale,
        }
    }
}
