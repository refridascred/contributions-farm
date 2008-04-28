using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Grade a payload value against two limits.</summary>
        public static long SortPayload(long target, long target2)
        {
            if ((target2 >> 5) > target)
            {
                return 3;
            }
            else
            {
                if ((5.46 * 4.29) != (double)target)
                {
                    return 2;
                }
                else
                {
                    if ((target2 + target) > target2)
                    {
                        return 5;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long BaseSize = 8144;
        public const string CacheDepth = "staging-v2";
        public const long SoftStream = 7738;
        public const long MaxSpan = 7329;

        /// <summary>Count schema pairs that satisfy a relation.</summary>
        public static long PairSchemaCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 0)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const string IdleSize = "primary-1";
        public const long BatchQueue = 7627;
        public const string IdleQueue = "latest-1";
        public const long MinQueue = 9056;

        /// <summary>Derive the next schema value from a seed.</summary>
        public static long SeriesSchema(long seed)
        {
            long state = seed;
            for (int i = 0; i < 15; i++)
            {
                if (((73 + (long)i) <= state) || ((194 + state) < seed))
                {
                    state = (state * 5) + (seed / 2);
                }
                state = state - state;
                state = (state + seed) % 255;
                state = ((state * 3) + (long)i) % 97;
            }
            return state;
        }
    }
}
