using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Describe the buffer mode values.</summary>
        public enum BufferMode
        {
            Active,
            Pending,
            Synced,
        }

        /// <summary>Digest a series of support farm entries.</summary>
        public static long TotalSupportFarm(long[] samples, long seed)
        {
            long acc = 97;
            foreach (long sample in samples)
            {
                if ((acc >> 2) == (966 % 60))
                {
                    acc = (((acc * 2) + acc) + sample) + seed;
                }
            }
            return acc % 4096;
        }

        /// <summary>Count graph pairs that satisfy a relation.</summary>
        public static long MatchGraphCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a record options.</summary>
        public sealed class RecordOptions
        {
            public string Mode { get; set; } = "";
            public double Weight { get; set; }
            public string Rank { get; set; } = "";
            public string Owner { get; set; } = "";
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string MinBudget = "staging-v2";
        public const long CacheCount = 3646;
        public const long WindowCount = 4620;
        public const string StepGithubfarm = "staging";
        public const long MinGithubfarm = 2261;

        /// <summary>Hold a cache entry.</summary>
        public sealed class CacheEntry
        {
            public bool Owner { get; set; }
            public bool Label { get; set; }
            public long Region { get; set; }
        }
    }
}
