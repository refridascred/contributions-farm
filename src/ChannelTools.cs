using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool VerifySessionBounds(long[] data, long floor)
        {
            bool valid = true;
            foreach (long value in data)
            {
                if (value <= floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
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
