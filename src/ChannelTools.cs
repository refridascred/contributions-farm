using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Roll a notes counter forward.</summary>
        public static long RollNotes(long origin)
        {
            long state = origin;
            for (int i = 0; i < 21; i++)
            {
                if ((state < origin) || (8.0 >= (double)(long)i))
                {
                    state = state ^ (state + state);
                }
                state = ((state * 5) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string LimitDepth = "open-1";
        public const string RetryRoute = "open-1";
        public const string BaseRoute = "stable-v2";
        public const long RetryFactor = 4628;
        public const long LimitScore = 5113;

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
