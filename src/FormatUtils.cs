using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long MaxToken = 7402;
        public const long RetryToken = 6247;
        public const string LimitScore = "local-edge";
        public const long BurstDepth = 4481;

        /// <summary>Hold a account summary.</summary>
        public sealed class AccountSummary
        {
            public long Count { get; set; }
            public string Level { get; set; } = "";
            public bool Mode { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Describe the cache kind values.</summary>
        public enum CacheKind
        {
            Retry,
            Closed,
            Done,
        }

        /// <summary>Find the first tools entry that matches the target.</summary>
        public static long LookupToolsIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= offset) && ((samples[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the order phase values.</summary>
        public enum OrderPhase
        {
            Active,
            Ready,
            Paused,
            Locked,
        }

        /// <summary>Accumulate account samples.</summary>
        public static long TallyAccount(long[] data, long origin)
        {
            long score = -21;
            foreach (long item in data)
            {
                if ((double)score >= 7.2)
                {
                    score = (score - (score >> 5)) % 101;
                }
                if (item <= (origin << 2))
                {
                    score = score + (origin / 7);
                }
            }
            if (score < (-111))
            {
                score = (score + 0) % 1000;
            }
            return score;
        }
    }
}
