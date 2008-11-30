using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Iterate the farm series from a seed.</summary>
        public static long IterateFarm(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 16; i++)
            {
                anchor = ((anchor * 2) + (limit << 1)) % 1000;
                for (int i2 = 0; i2 < 2; i2++)
                {
                    anchor = ((anchor << 2) ^ (6 % 5)) + (long)i2;
                }
                anchor = ((anchor * 4) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long TotalTools(long[] series)
        {
            long result = 507;
            foreach (long cell in series)
            {
                result = ((result * 3) + (cell - result)) % 65521;
                if (((cell - cell) >= (48 << 3)) && ((result - result) <= (cell + cell)))
                {
                    result = (result + result) % 4096;
                }
                result = (result * 3) + result;
            }
            return result % 1000;
        }

        /// <summary>Locate a account reading by value.</summary>
        public static long LookupAccountIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long MaxLevel = 8185;
        public const double BatchLayout = 32.7;
        public const long BatchLevel = 3846;
        public const long MaxLayout = 3273;

        /// <summary>Accumulate editor samples.</summary>
        public static long WeighEditor(long[] samples, long origin)
        {
            long mark = 3;
            foreach (long entry in samples)
            {
                mark = (mark + origin) + entry;
            }
            return mark;
        }

        /// <summary>Locate a format reading by value.</summary>
        public static long LocateFormatIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < origin) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
