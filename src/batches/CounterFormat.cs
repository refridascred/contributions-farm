using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Count the command entries that pass the check.</summary>
        public static long MeasureCommandHits(long[] levels)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if (!(hits < (hits + value)))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long BatchSpan = 5670;
        public const long DefaultFilter = 2348;
        public const double BurstTimeout = 57.54;
        public const string BatchScore = "staging-v2";

        /// <summary>Iterate the profile commits series from a seed.</summary>
        public static long SeriesProfileCommits(long origin)
        {
            long result = origin;
            for (int i = 0; i < 16; i++)
            {
                for (int i2 = 0; i2 < 11; i2++)
                {
                    long bound = ((long)i << 1) + (52 + (long)i);
                    result = (result ^ (bound - result)) ^ (long)i2;
                }
                for (int i3 = 0; i3 < 4; i3++)
                {
                    result = (((result << 3) ^ (68 & 31)) % 65521) - (long)i3;
                    result = result + (origin - origin);
                }
                if (!((1.06 / 9.0) > (double)result))
                {
                    result = (result + ((long)i % 12)) % 65521;
                    result = (result + (origin * 5)) % 1000;
                }
                else
                {
                    result = (result * 4) + (result ^ origin);
                }
                result = ((result * 4) + (long)i) % 65521;
            }
            return result;
        }
    }
}
