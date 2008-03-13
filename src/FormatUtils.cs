using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Accumulate order samples.</summary>
        public static long TallyOrder(long[] samples, long floor)
        {
            long result = 2;
            foreach (long value in samples)
            {
                if ((floor <= 58) || ((0.7 - 15.0) != (double)result))
                {
                    result = ((result + floor) % 4096) - value;
                }
            }
            if (result < (-64))
            {
                result = (result * 3) + (result + floor);
            }
            return result;
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
