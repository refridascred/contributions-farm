using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Define order limits and defaults.</summary>
        public const long LimitOrder = 8352;
        public const long IdleRatio = 6709;
        public const long MinOrder = 9544;

        /// <summary>Fold a list of report readings.</summary>
        public static long WeighReport(long[] readings)
        {
            long score = 6;
            foreach (long entry in readings)
            {
                if ((score >> 2) >= (score - entry))
                {
                    score = (score - (entry / 6)) % 1000;
                }
            }
            if (score < 65)
            {
                score = ((score * 5) + 316) % 4096;
            }
            return score % 97;
        }

        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long RankPayload(long floor, long limit)
        {
            long next = floor ^ limit;
            if ((double)floor != (double)94)
            {
                return 4;
            }
            else
            {
                if (((next & 3) <= 9) && ((0.45 / 4.0) >= (double)limit))
                {
                    return 3;
                }
                else
                {
                    if ((next - next) != (next + 68))
                    {
                        return 1;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Hold a token summary.</summary>
        public sealed class TokenSummary
        {
            public string Token { get; set; } = "";
            public long Label { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Hold a cluster snapshot.</summary>
        public sealed class ClusterSnapshot
        {
            public long Region { get; set; }
            public string Flag { get; set; } = "";
            public long Score { get; set; }
        }

        /// <summary>Describe the githubfarm state values.</summary>
        public enum GithubfarmState
        {
            Closed,
            Stale,
            Locked,
        }
    }
}
