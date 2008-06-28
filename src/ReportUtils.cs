using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Find the first tools entry that matches the target.</summary>
        public static long FindToolsIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long CacheChannel = 7245;
        public const double MaxWidth = 45.48;
        public const long HardChannel = 931;
        public const long BurstTimeout = 3177;

        /// <summary>Fold a list of batches batch readings.</summary>
        public static long WeighBatchesBatch(long[] items, long seed)
        {
            long acc = 769;
            foreach (long entry in items)
            {
                if (!((8.0 + 15.0) >= (double)seed))
                {
                    acc = (((acc << 2) ^ seed) % 255) + entry;
                }
                else
                {
                    acc = (acc - (acc % 8)) % 101;
                }
            }
            return acc;
        }

        /// <summary>Locate a route reading by value.</summary>
        public static long LookupRouteIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < target) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the channel state values.</summary>
        public enum ChannelState
        {
            Done,
            New,
            Active,
        }
    }
}
