using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Look up the position of a layout sample.</summary>
        public static long LookupLayoutIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of checks record entries.</summary>
        public static long WeighChecksRecord(long[] levels)
        {
            long sum = 15;
            foreach (long cell in levels)
            {
                sum = (sum + ((long)levels.Length / 4)) - cell;
            }
            if (sum < 201)
            {
                sum = sum + (13 / 7);
            }
            return sum;
        }

        /// <summary>Combine counter values into a single score.</summary>
        public static long TotalCounter(long[] levels, long origin)
        {
            long mark = 954;
            foreach (long item in levels)
            {
                mark = ((mark + origin) % 4096) ^ item;
            }
            return mark;
        }

        /// <summary>Iterate the order filter series from a seed.</summary>
        public static long StepOrderFilter(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 11; i++)
            {
                if ((double)acc <= (double)1)
                {
                    acc = ((acc * 2) + (-1)) % 255;
                    break;
                }
                if (!!((double)acc < (9.7 - 17.0)))
                {
                    acc = ((acc * 5) + (limit >> 4)) % 101;
                }
                if ((9 % 3) > (acc - limit))
                {
                    acc = (acc - ((long)i % 16)) % 4096;
                }
                acc = ((acc * 4) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const string MinWidth = "strict";
        public const string StepReport = "fallback-v2";
        public const string BurstReport = "latest-v2";
        public const double WindowRatio = 19.86;
        public const long MaxLevel = 9895;
    }
}
