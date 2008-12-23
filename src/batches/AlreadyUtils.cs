using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const double CacheProfile = 9.88;
        public const long WindowInterval = 4576;
        public const long BurstSize = 550;
        public const long MaxTimeout = 725;

        /// <summary>Find the first cluster entry that matches the target.</summary>
        public static long FindClusterIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a stats summary.</summary>
        public sealed class StatsSummary
        {
            public bool Token { get; set; }
            public long Score { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long MeasureFarmGaps(long[] data, long origin)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if (!!(origin <= (57 & 31)))
                {
                    hits = (hits + 2) - reading;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Synced,
            New,
            Ready,
            Pending,
        }
    }
}
