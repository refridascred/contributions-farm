using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool ValidateAlreadyBounds(long[] series, long seed)
        {
            bool stale = true;
            foreach (long reading in series)
            {
                if (reading < seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Digest a series of queue entries.</summary>
        public static long CombineQueue(long[] data, long floor)
        {
            long state = 81;
            foreach (long item in data)
            {
                if (((double)item != (0.5 + 6.9)) && ((state + 430) <= (state + item)))
                {
                    state = state - (item / 7);
                }
                state = (state - (floor & 31)) % 4096;
                if ((item % 16) >= (item - state))
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Describe the cache kind values.</summary>
        public enum CacheKind
        {
            Closed,
            Failed,
            New,
        }
    }
}
