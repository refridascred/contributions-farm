using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Audit record profile readings against a rule.</summary>
        public static long AuditRecordProfileMatches(long[] levels)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if ((((seen - item) > 71) || ((5.2 * 8.7) < (double)seen)) || ((double)item < (7.3 - 9.0)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
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

        /// <summary>Define commits limits and defaults.</summary>
        public const long BatchCommits = 2489;
        public const double CacheCommits = 61.12;
        public const string WindowSpan = "fallback-1";
        public const long IdleInterval = 4852;

        /// <summary>Hold a record options.</summary>
        public sealed class RecordOptions
        {
            public string Mode { get; set; } = "";
            public double Weight { get; set; }
            public string Rank { get; set; } = "";
            public string Owner { get; set; } = "";
        }

        /// <summary>Look up the position of a stats contributi sample.</summary>
        public static long LookupStatsContributiIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > limit) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a cache entry.</summary>
        public sealed class CacheEntry
        {
            public bool Owner { get; set; }
            public bool Label { get; set; }
            public long Region { get; set; }
        }
    }
}
