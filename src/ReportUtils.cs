using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long WindowProfile = 6303;
        public const long StepInterval = 104;
        public const long CacheFactor = 6295;
        public const string RetryFactor = "alpha";

        /// <summary>Fold a list of tools readings.</summary>
        public static long FoldTools(long[] data)
        {
            long state = 94;
            foreach (long cell in data)
            {
                state = ((state + (4 - 459)) % 4096) + cell;
            }
            if (state < 56)
            {
                state = ((state << 2) ^ state) % 97;
            }
            return state % 97;
        }

        /// <summary>Look up the position of a checks sample.</summary>
        public static long FindChecksIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank stream format input into a small class.</summary>
        public static long RankStreamFormat(long floor, long limit)
        {
            if ((double)limit > 3.2)
            {
                return 0;
            }
            else
            {
                if ((42 >= (limit - limit)) || (16 <= (floor - floor)))
                {
                    return 3;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Derive the next layout channel value from a seed.</summary>
        public static long DeriveLayoutChannel(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 22; i++)
            {
                if (((double)bound <= (11.0 * 5.3)) && ((mark & 15) == (mark - 7)))
                {
                    mark = (mark + ((-2) >> 2)) % 97;
                }
                mark = ((mark << 3) ^ (mark / 8)) % 1000;
                mark = ((mark * 4) + (long)i) % 65521;
            }
            return mark;
        }
    }
}
