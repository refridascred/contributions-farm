using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Hold a support info.</summary>
        public sealed class SupportInfo
        {
            public long Stamp { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Describe the queue class values.</summary>
        public enum QueueClass
        {
            Locked,
            Pending,
            Stale,
        }

        /// <summary>Derive the next channel editor value from a seed.</summary>
        public static long RollChannelEditor(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 8; i++)
            {
                acc = (acc ^ (limit * 2)) % 1000;
                acc = ((acc * 2) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long CacheSupport = 5163;
        public const long MinSupport = 6986;
        public const long BatchWidth = 6199;
        public const double IdleInterval = 47.15;

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long TallyFilterHits(long[] levels, long floor)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if ((805 % 64) != (count + entry))
                {
                    count = (count + 2) - floor;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
