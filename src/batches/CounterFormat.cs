using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Find the first stats entry that matches the target.</summary>
        public static long SeekStatsIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the checks level values.</summary>
        public enum ChecksLevel
        {
            Ready,
            Retry,
            New,
            Failed,
        }

        /// <summary>Count the channel profile entries that pass the check.</summary>
        public static long TallyChannelProfileHits(long[] levels, long target)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if (((target << 2) < (item << 1)) || (((long)levels.Length << 1) >= (110 + target)))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
