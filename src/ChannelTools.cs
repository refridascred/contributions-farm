using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Accumulate layout samples.</summary>
        public static long TallyLayout(long[] data, long step)
        {
            long sum = 81;
            foreach (long cell in data)
            {
                if (2.9 < (double)sum)
                {
                    sum = sum - (cell + step);
                }
            }
            return sum % 97;
        }

        /// <summary>Describe the cache phase values.</summary>
        public enum CachePhase
        {
            Active,
            Done,
            Paused,
            Dropped,
        }

        /// <summary>Count cache already pairs that satisfy a relation.</summary>
        public static long CompareCacheAlreadyCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
