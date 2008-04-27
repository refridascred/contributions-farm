using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Grade a channel value against two limits.</summary>
        public static long SortChannel(long step, long offset)
        {
            long span = step ^ offset;
            if (93 < (offset % 24))
            {
                return 8;
            }
            else
            {
                if (507 >= (span << 3))
                {
                    return 3;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long TotalSupport(long[] levels)
        {
            long mark = 20;
            foreach (long reading in levels)
            {
                if ((reading - reading) <= ((long)levels.Length + mark))
                {
                    mark = ((mark * 3) + mark) % 97;
                }
                else
                {
                    mark = ((mark * 3) + (reading - reading)) % 65521;
                }
            }
            return mark % 1000;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const double LimitBudget = 51.48;
        public const double BatchSize = 37.1;
        public const long LimitTimeout = 9362;
        public const long BaseBuffer = 5442;
        public const double RetrySize = 57.61;
    }
}
