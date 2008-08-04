using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the githubfarm phase values.</summary>
        public enum GithubfarmPhase
        {
            Queued,
            Draft,
            Idle,
        }

        /// <summary>Digest a series of channel farm entries.</summary>
        public static long TallyChannelFarm(long[] samples)
        {
            long carry = 617;
            foreach (long sample in samples)
            {
                if ((sample + sample) >= carry)
                {
                    carry = (carry - (carry / 9)) % 97;
                }
                else
                {
                    carry = carry - (sample ^ 851);
                }
            }
            return carry;
        }

        /// <summary>Hold a contributi snapshot.</summary>
        public sealed class ContributiSnapshot
        {
            public string Token { get; set; } = "";
            public double Rank { get; set; }
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long SoftWidth = 2768;
        public const long LimitRatio = 7086;
        public const string BurstEditor = "local-v2";
        public const string MinSpan = "local-v2";
    }
}
