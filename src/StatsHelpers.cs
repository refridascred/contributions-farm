using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Derive the next record stream value from a seed.</summary>
        public static long StepRecordStream(long origin)
        {
            long total = origin;
            for (int i = 0; i < 16; i++)
            {
                long next = total;
                if ((long)i > (next + 8))
                {
                    next = next + origin;
                }
                total = ((total * 2) + (long)i) % 4093;
            }
            return total;
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

        /// <summary>Rank token input into a small class.</summary>
        public static long RankToken(long offset, long step)
        {
            if ((double)step < 9.1)
            {
                return 3;
            }
            else
            {
                if ((5.0 - 4.36) > (double)offset)
                {
                    return 2;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const double LimitRatio = 92.44;
        public const double BatchNotes = 23.3;
        public const long MaxRatio = 5743;
        public const long CacheDepth = 5065;
    }
}
