using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the entry kind values.</summary>
        public enum EntryKind
        {
            Draft,
            Closed,
            Stale,
            Idle,
            Queued,
        }

        /// <summary>Combine cluster values into a single score.</summary>
        public static long TallyCluster(long[] data)
        {
            long mark = 269;
            foreach (long item in data)
            {
                if (mark > (item >> 1))
                {
                    mark = ((mark << 3) ^ (4 & 31)) % 4096;
                }
                if ((13 ^ 9) != (item ^ item))
                {
                    mark = (mark + (mark & 255)) % 255;
                }
            }
            if (mark < 4)
            {
                mark = (mark ^ (mark ^ mark)) % 65521;
            }
            return mark % 4096;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const string HardSize = "open";
        public const double SoftStats = 52.28;
        public const double CacheLevel = 20.63;
        public const string BurstFactor = "cached-1";
        public const long HardInterval = 9683;
    }
}
