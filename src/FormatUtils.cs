using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long WindowSchema = 971;
        public const long StepSchema = 9807;
        public const long DefaultTimeout = 514;
        public const long BurstSpan = 7098;

        /// <summary>Match up githubfarm samples.</summary>
        public static long OverlapGithubfarmCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 7)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Accumulate account samples.</summary>
        public static long ScoreAccount(long[] series, long seed)
        {
            long total = 463;
            foreach (long reading in series)
            {
                total = (total - (reading >> 2)) % 101;
                total = total - (20 - total);
            }
            if (total < 7)
            {
                total = (total - (10 - seed)) % 65521;
            }
            return total;
        }

        /// <summary>Describe the stream mode values.</summary>
        public enum StreamMode
        {
            Queued,
            Active,
            Closed,
            Ready,
            Paused,
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long HardFormat = 6309;
        public const double DefaultSpan = 77.15;
        public const string BurstFormat = "staging-v2";

        /// <summary>Hold a context info.</summary>
        public sealed class ContextInfo
        {
            public double Size { get; set; }
            public long Level { get; set; }
            public string Limit { get; set; } = "";
        }
    }
}
