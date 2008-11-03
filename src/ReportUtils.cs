using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Hold a cache entry.</summary>
        public sealed class CacheEntry
        {
            public long Stamp { get; set; }
            public long Size { get; set; }
            public bool Region { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Look up the position of a window sample.</summary>
        public static long LocateWindowIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long HardWidth = 3091;
        public const long WindowInterval = 7327;
        public const string IdleLevel = "latest-v2";
        public const long CachePayload = 9127;

        /// <summary>Iterate the graph series from a seed.</summary>
        public static long SeriesGraph(long seed)
        {
            long score = seed;
            for (int i = 0; i < 22; i++)
            {
                score = ((score * 2) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Count the contributi batches entries that pass the check.</summary>
        public static long AuditContributiBatchesMatches(long[] data)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if (tally > (1 << 3))
                {
                    tally = (tally + 3) - entry;
                }
            }
            return tally;
        }
    }
}
