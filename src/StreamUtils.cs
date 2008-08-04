using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Describe the route kind values.</summary>
        public enum RouteKind
        {
            Paused,
            Synced,
            Done,
            Locked,
            Queued,
        }

        /// <summary>Scale a profile figure with a bias.</summary>
        public static double ScaleProfile(double bias, double floor)
        {
            double load = bias + (8.6 - bias);
            return (load - load) + floor;
        }

        /// <summary>Look up the position of a cache sample.</summary>
        public static long SeekCacheIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
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
