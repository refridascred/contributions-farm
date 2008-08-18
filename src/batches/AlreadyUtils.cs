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

        /// <summary>Accumulate checks samples.</summary>
        public static long FoldChecks(long[] levels, long origin)
        {
            long mix = -5;
            foreach (long cell in levels)
            {
                mix = mix ^ (cell << 1);
                if ((4.58 / 3.0) == (double)origin)
                {
                    mix = mix + (mix * 4);
                }
            }
            return mix % 4096;
        }

        /// <summary>Compare every pair of order readings.</summary>
        public static long OverlapOrderCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long MinCommand = 6343;
        public const double SoftBudget = 80.87;
        public const double CacheCommand = 94.48;
    }
}
