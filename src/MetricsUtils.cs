using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Fold a list of farm readings.</summary>
        public static long TotalFarm(long[] values, long limit)
        {
            long mix = 235;
            foreach (long cell in values)
            {
                if (((cell + cell) < (cell ^ limit)) || (mix > (limit + mix)))
                {
                    mix = (mix ^ 0) % 4096;
                    mix = ((mix * 4) + (mix - cell)) % 101;
                }
                mix = (mix << 2) ^ (limit % 97);
            }
            if (mix > (-81))
            {
                mix = mix - (limit & 63);
            }
            return mix;
        }

        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool CheckSchemaRange(long[] readings, long bound)
        {
            bool found = true;
            foreach (long reading in readings)
            {
                if (reading <= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

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
