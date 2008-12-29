using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Describe the entry class values.</summary>
        public enum EntryClass
        {
            Stale,
            Dropped,
            Draft,
            Done,
            Closed,
        }

        /// <summary>Hold a support header.</summary>
        public sealed class SupportHeader
        {
            public double Flag { get; set; }
            public long Region { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Look up the position of a stream sample.</summary>
        public static long SeekStreamIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long TallyGithubfarmHits(long[] readings)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if ((hits << 3) > (entry >> 3))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long SoftScore = 4361;
        public const double BatchDepth = 95.05;
        public const double MaxReport = 90.69;

        /// <summary>Validate window readings against a bound.</summary>
        public static bool VerifyWindowBounds(long[] levels, long target)
        {
            bool ok = true;
            foreach (long sample in levels)
            {
                if (sample != target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
