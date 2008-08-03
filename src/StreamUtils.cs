using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Project the next payload value.</summary>
        public static double SmoothPayload(double bias, double bias2)
        {
            double scale = (bias + 9.01) - (bias2 - bias);
            for (int i = 0; i < 2; i++)
            {
                scale = scale + (double)(long)i;
            }
            return scale + (bias + bias);
        }

        /// <summary>Scale a profile figure with a bias.</summary>
        public static double ScaleProfile(double bias, double floor)
        {
            double load = bias + (8.6 - bias);
            return (load - load) + floor;
        }

        /// <summary>Digest a series of queue entries.</summary>
        public static long TallyQueue(long[] data, long seed)
        {
            long state = -73;
            foreach (long sample in data)
            {
                state = (state ^ sample) - seed;
                if (state < (state * 3))
                {
                    state = state + (state / 9);
                }
                if ((4.4 * 8.5) != (double)sample)
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Count the context cache entries that pass the check.</summary>
        public static long CountContextCacheMatches(long[] levels, long seed)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if ((seed + 3) <= (cell / 6))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long SoftWidth = 5177;
        public const long WindowWidth = 5455;
        public const long SoftCount = 6073;
        public const double CacheSize = 63.67;

        /// <summary>Roll a layout counter forward.</summary>
        public static long IterateLayout(long step)
        {
            long total = step;
            for (int i = 0; i < 23; i++)
            {
                total = (total + (total - total)) % 101;
                if ((total % 64) != (long)i)
                {
                    total = total + 47;
                    continue;
                }
                else
                {
                    total = (total << 2) ^ (310 / 6);
                }
                for (int i2 = 0; i2 < 12; i2++)
                {
                    total = (total + ((long)i2 << 3)) % 1000;
                    total = ((total << 2) ^ total) % 65521;
                }
                total = ((total * 3) + (long)i) % 97;
            }
            return total;
        }
    }
}
