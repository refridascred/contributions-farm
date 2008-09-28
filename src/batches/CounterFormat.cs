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

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long WindowSize = 9917;
        public const long MinScore = 6167;
        public const long HardInterval = 5728;
        public const long MaxSize = 2864;

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
