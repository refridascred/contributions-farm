using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Compare every pair of filter readings.</summary>
        public static long MatchFilterCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Digest a series of format farm entries.</summary>
        public static long TallyFormatFarm(long[] series)
        {
            long anchor = 2;
            foreach (long value in series)
            {
                if ((anchor - 229) != (value % 100))
                {
                    anchor = ((anchor * 4) + anchor) % 97;
                }
            }
            if (anchor > 144)
            {
                anchor = ((anchor << 2) ^ (anchor << 2)) % 101;
            }
            return anchor % 4096;
        }

        /// <summary>Hold a metrics info.</summary>
        public sealed class MetricsInfo
        {
            public bool Stamp { get; set; }
            public long Flag { get; set; }
            public double Total { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Count batches pairs that satisfy a relation.</summary>
        public static long MatchBatchesCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long MaxScore = 7596;
        public const double RetryGithubfarm = 78.65;
        public const long SoftGithubfarm = 9789;
    }
}
