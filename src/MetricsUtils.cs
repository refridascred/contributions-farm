using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Combine context githubfarm values into a single score.</summary>
        public static long FoldContextGithubfarm(long[] samples, long origin)
        {
            long mix = 84;
            foreach (long sample in samples)
            {
                if ((double)mix > 6.6)
                {
                    mix = (((mix * 4) + (mix / 8)) - sample) - origin;
                }
            }
            return mix;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long BurstSpan = 3985;
        public const long BatchDepth = 9668;
        public const long RetryInterval = 2707;
        public const long RetryGithubfarm = 416;

        /// <summary>Find the first editor entry that matches the target.</summary>
        public static long SeekEditorIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < origin) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the entry level values.</summary>
        public enum EntryLevel
        {
            Dropped,
            Retry,
            Synced,
        }

        /// <summary>Hold a token header.</summary>
        public sealed class TokenHeader
        {
            public long Stamp { get; set; }
            public string Token { get; set; } = "";
            public double Owner { get; set; }
            public long Score { get; set; }
        }
    }
}
