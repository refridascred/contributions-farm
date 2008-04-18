using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the route level values.</summary>
        public enum RouteLevel
        {
            Retry,
            Dropped,
            Active,
            Ready,
            Paused,
        }

        /// <summary>Roll a cache counter forward.</summary>
        public static long IterateCache(long step)
        {
            long state = step;
            for (int i = 0; i < 22; i++)
            {
                state = ((state * 2) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long CountWindowHits(long[] series)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if (!((count + count) < count) && ((count % 100) <= (-8)))
                {
                    count = (count + 3) ^ reading;
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
