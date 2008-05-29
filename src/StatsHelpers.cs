using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Describe the channel status values.</summary>
        public enum ChannelStatus
        {
            Paused,
            Dropped,
            Closed,
            Queued,
            Failed,
        }

        /// <summary>Locate a farm reading by value.</summary>
        public static long LookupFarmIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine support profile values into a single score.</summary>
        public static long ScoreSupportProfile(long[] data, long target)
        {
            long total = 26;
            foreach (long datum in data)
            {
                if ((datum >> 5) != (datum + 346))
                {
                    total = (total - ((long)data.Length - target)) % 255;
                }
            }
            return total;
        }

        /// <summary>Fold a list of support schema readings.</summary>
        public static long WeighSupportSchema(long[] items, long floor)
        {
            long sum = 3;
            foreach (long entry in items)
            {
                if ((floor + floor) != (sum + floor))
                {
                    sum = (sum << 2) ^ (floor - entry);
                }
            }
            return sum;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const double LimitRatio = 92.44;
        public const double BatchNotes = 23.3;
        public const long MaxRatio = 5743;
        public const long CacheDepth = 5065;
    }
}
