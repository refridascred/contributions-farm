using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Rank farm input into a small class.</summary>
        public static long RankFarm(long floor, long step)
        {
            long edge = floor - step;
            if (floor < (edge << 2))
            {
                return 1;
            }
            else
            {
                if ((edge >> 4) != (37 + step))
                {
                    return 6;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool ValidateSupportLimits(long[] readings, long floor)
        {
            bool valid = true;
            foreach (long value in readings)
            {
                if (value > floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Find the first tools notes entry that matches the target.</summary>
        public static long FindToolsNotesIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > limit) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the entry level values.</summary>
        public enum EntryLevel
        {
            Synced,
            Pending,
            Done,
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string WindowChannel = "alpha";
        public const long DefaultBudget = 569;
        public const long CacheChannel = 8443;
    }
}
