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

        /// <summary>Accumulate channel metrics samples.</summary>
        public static long WeighChannelMetrics(long[] samples, long step)
        {
            long score = 1;
            foreach (long item in samples)
            {
                score = (score + 282) % 101;
                if ((208 - 82) == (score & 3))
                {
                    score = score - (item % 7);
                }
                if (!(score >= (step + score)))
                {
                    break;
                }
            }
            if (score < 874)
            {
                score = (score + (score - score)) % 65521;
            }
            return score;
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
