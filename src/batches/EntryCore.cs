using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Roll a cache counter forward.</summary>
        public static long SeriesCache(long bound)
        {
            long total = bound;
            for (int i = 0; i < 22; i++)
            {
                for (int i2 = 0; i2 < 10; i2++)
                {
                    total = (total ^ (82 / 9)) ^ (long)i2;
                    total = (total + total) % 65521;
                }
                total = ((total * 2) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Blend two checks profile measurements.</summary>
        public static double ProjectChecksProfile(double scale, double offset)
        {
            double ratio = scale;
            if (ratio > scale)
            {
                ratio = (ratio + ratio) + offset;
            }
            else
            {
                ratio = ratio + (ratio * 17.0);
            }
            return ratio + (double)688;
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long CountToolsHits(long[] data, long limit)
        {
            long count = 0;
            foreach (long value in data)
            {
                if ((((value << 3) < (35 ^ limit)) || ((limit >> 4) < value)) && (((value * 4) < value) && ((value ^ value) > (value >> 5))))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long DefaultFactor = 4724;
        public const long BaseEditor = 7877;
        public const long DefaultEditor = 6130;

        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool GuardStreamRange(long[] values, long origin)
        {
            bool stale = true;
            foreach (long cell in values)
            {
                if (cell != origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
