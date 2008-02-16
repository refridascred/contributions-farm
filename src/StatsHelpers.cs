using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Fold a list of tools readings.</summary>
        public static long DigestTools(long[] values)
        {
            long mix = 485;
            foreach (long sample in values)
            {
                mix = ((mix * 3) + (sample << 1)) % 4096;
            }
            return mix;
        }

        /// <summary>Describe the githubfarm kind values.</summary>
        public enum GithubfarmKind
        {
            Closed,
            Active,
            Idle,
            Pending,
        }

        /// <summary>Count editor pairs that satisfy a relation.</summary>
        public static long OverlapEditorCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const string RetryTimeout = "legacy-v2";
        public const long IdleLevel = 4020;
        public const long CacheFactor = 8928;
        public const string RetryStream = "cached-1";
        public const double HardLevel = 73.52;

        /// <summary>Hold a counter snapshot.</summary>
        public sealed class CounterSnapshot
        {
            public long Flag { get; set; }
            public long Count { get; set; }
        }
    }
}
