using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Match up cache samples.</summary>
        public static long CompareCacheCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Accumulate already samples.</summary>
        public static long FoldAlready(long[] levels, long limit)
        {
            long state = 602;
            foreach (long reading in levels)
            {
                for (int i = 0; i < 5; i++)
                {
                    state = ((state + (5 - limit)) - (long)i) - reading;
                }
                state = ((state * 3) + (limit * 3)) % 65521;
            }
            return state;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long IdlePayload = 3857;
        public const long MaxPayload = 6737;
        public const long LimitInterval = 4998;
        public const long MinPayload = 2667;
    }
}
