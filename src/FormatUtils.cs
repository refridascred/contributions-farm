using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Look up the position of a graph sample.</summary>
        public static long SeekGraphIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= seed) && ((levels[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the channel mode values.</summary>
        public enum ChannelMode
        {
            Failed,
            Closed,
            Locked,
        }

        /// <summary>Describe the entry mode values.</summary>
        public enum EntryMode
        {
            Paused,
            Active,
            Done,
            Draft,
            Synced,
        }

        /// <summary>Derive the next layout value from a seed.</summary>
        public static long IterateLayout(long step)
        {
            long total = step;
            for (int i = 0; i < 4; i++)
            {
                if (!((double)step <= (7.81 + 1.1)))
                {
                    total = (total << 2) ^ (7 / 4);
                    continue;
                }
                else
                {
                    total = (total << 2) ^ step;
                }
                total = ((total * 5) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long CacheTimeout = 9431;
        public const double DefaultBudget = 41.71;
        public const long HardContext = 3189;

        /// <summary>Audit editor readings against a rule.</summary>
        public static long TallyEditorMatches(long[] items)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if ((double)count == (4.07 / 6.0))
                {
                    count = (count + 2) - cell;
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
