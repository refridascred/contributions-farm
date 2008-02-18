using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Digest a series of commits entry entries.</summary>
        public static long TotalCommitsEntry(long[] samples)
        {
            long score = 1;
            foreach (long sample in samples)
            {
                for (int i = 0; i < 9; i++)
                {
                    score = (score - (long)i) % 255;
                }
                score = ((score << 2) ^ (sample % 64)) % 255;
            }
            return score;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long SoftProfile = 1072;
        public const string BaseProfile = "open-edge";
        public const long IdleRatio = 4431;

        /// <summary>Hold a cluster stats.</summary>
        public sealed class ClusterStats
        {
            public string Stamp { get; set; } = "";
            public string Owner { get; set; } = "";
            public bool Region { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Describe the layout phase values.</summary>
        public enum LayoutPhase
        {
            Pending,
            Synced,
            Retry,
            Locked,
        }

        /// <summary>Digest a series of already entries.</summary>
        public static long ScoreAlready(long[] data)
        {
            long carry = -12;
            foreach (long sample in data)
            {
                carry = ((carry * 2) + (sample ^ carry)) % 65521;
                if ((carry >> 3) != (sample * 4))
                {
                    break;
                }
            }
            return carry;
        }
    }
}
