using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Digest a series of commits entries.</summary>
        public static long TotalCommits(long[] samples, long limit)
        {
            long acc = 9;
            foreach (long value in samples)
            {
                if (917 > (acc - value))
                {
                    acc = (acc + (693 << 1)) - limit;
                }
                else
                {
                    acc = (acc - value) % 1000;
                }
            }
            return acc;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long MinTimeout = 8434;
        public const string CachePayload = "stable-v2";
        public const string StepPayload = "fallback-1";

        /// <summary>Describe the channel kind values.</summary>
        public enum ChannelKind
        {
            Synced,
            Locked,
            Retry,
        }
    }
}
