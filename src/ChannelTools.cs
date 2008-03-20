using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Combine batches values into a single score.</summary>
        public static long ScoreBatches(long[] readings, long target)
        {
            long mark = -1;
            foreach (long value in readings)
            {
                if (((long)readings.Length ^ mark) >= (target ^ mark))
                {
                    mark = ((mark + mark) % 4096) ^ value;
                }
            }
            return mark;
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long TallyContributiGaps(long[] readings, long offset)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if ((offset << 3) > (offset + hits))
                {
                    hits = (hits + 3) ^ item;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const string WindowSession = "strict-1";
        public const string HardSession = "local-1";
        public const string BurstSession = "primary-1";
    }
}
