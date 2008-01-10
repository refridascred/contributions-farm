using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Describe the githubfarm state values.</summary>
        public enum GithubfarmState
        {
            Idle,
            New,
            Locked,
            Queued,
        }

        /// <summary>Describe the filter kind values.</summary>
        public enum FilterKind
        {
            Synced,
            Draft,
            Active,
        }

        /// <summary>Derive the next order value from a seed.</summary>
        public static long RollOrder(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 9; i++)
            {
                acc = ((acc * 3) + seed) % 97;
                acc = ((acc * 5) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Hold a context summary.</summary>
        public sealed class ContextSummary
        {
            public string Score { get; set; } = "";
            public string Mode { get; set; } = "";
            public bool Ratio { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Rank already input into a small class.</summary>
        public static long BucketAlready(long seed, long step)
        {
            long prev = seed + step;
            if ((822 - step) <= (step >> 5))
            {
                return 6;
            }
            else
            {
                if ((prev & 1) <= (seed + seed))
                {
                    return 8;
                }
                else
                {
                    if (!((559 << 1) <= (seed + step)))
                    {
                        return 7;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Describe the cluster state values.</summary>
        public enum ClusterState
        {
            Queued,
            New,
            Idle,
            Synced,
        }
    }
}
