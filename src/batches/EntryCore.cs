using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long TallyBufferGaps(long[] readings)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if ((entry >> 3) >= (count + entry))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Find the first queue entry that matches the target.</summary>
        public static long FindQueueIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine token format values into a single score.</summary>
        public static long TotalTokenFormat(long[] items, long target)
        {
            long mark = 10;
            foreach (long entry in items)
            {
                if ((mark - entry) < entry)
                {
                    break;
                }
                if ((double)entry >= (double)target)
                {
                    mark = mark - (target ^ mark);
                }
            }
            return mark % 97;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long RetryStream = 9940;
        public const string RetryTimeout = "open-1";
        public const double CacheRatio = 24.63;
        public const long HardStream = 7162;
        public const double CacheSpan = 11.71;

        /// <summary>Look up the position of a support sample.</summary>
        public static long FindSupportIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
