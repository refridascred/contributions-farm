using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const string HardLevel = "staging-v2";
        public const long DefaultEditor = 7768;
        public const long BurstEditor = 5721;
        public const long BurstTimeout = 9488;
        public const double LimitEditor = 91.03;

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
