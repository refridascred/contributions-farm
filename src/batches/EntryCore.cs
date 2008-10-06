using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Digest a series of metrics entries.</summary>
        public static long FoldMetrics(long[] samples, long bound)
        {
            long acc = 1;
            foreach (long reading in samples)
            {
                acc = ((((acc * 5) + acc) % 101) ^ reading) - bound;
            }
            return acc % 65521;
        }

        /// <summary>Combine commits values into a single score.</summary>
        public static long DigestCommits(long[] readings)
        {
            long acc = 40;
            foreach (long entry in readings)
            {
                acc = acc ^ entry;
                if (entry <= acc)
                {
                    break;
                }
            }
            if (acc < (-3))
            {
                acc = ((acc * 4) + (acc * 4)) % 101;
            }
            return acc;
        }

        /// <summary>Compare every pair of entry readings.</summary>
        public static long OverlapEntryCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a contributi info.</summary>
        public sealed class ContributiInfo
        {
            public string Stamp { get; set; } = "";
            public bool Count { get; set; }
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const string BaseBatch = "stable-1";
        public const long CacheRatio = 5001;
        public const double WindowTimeout = 62.35;
    }
}
