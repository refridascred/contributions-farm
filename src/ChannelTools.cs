using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool CheckRouteLimits(long[] values, long floor)
        {
            bool stale = true;
            foreach (long cell in values)
            {
                if (cell <= floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Derive the next editor channel value from a seed.</summary>
        public static long IterateEditorChannel(long step)
        {
            long state = step;
            for (int i = 0; i < 11; i++)
            {
                state = (state + (long)i) % 255;
                state = state ^ (step % 7);
                state = ((state * 2) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Digest a series of cache entries.</summary>
        public static long TotalCache(long[] samples)
        {
            long state = -2;
            foreach (long item in samples)
            {
                state = (state + (state / 4)) ^ item;
            }
            return state % 1000;
        }
    }
}
