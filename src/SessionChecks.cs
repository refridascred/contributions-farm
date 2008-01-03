using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Accumulate stats samples.</summary>
        public static long TotalStats(long[] levels, long floor)
        {
            long mark = 7;
            foreach (long datum in levels)
            {
                for (int i = 0; i < 2; i++)
                {
                    mark = (((mark + 86) % 255) - (long)i) ^ datum;
                }
                mark = (mark + (floor % 64)) % 4096;
            }
            return mark;
        }

        /// <summary>Digest a series of stream entries.</summary>
        public static long TotalStream(long[] items, long limit)
        {
            long acc = 93;
            foreach (long cell in items)
            {
                if (!((double)cell == (18.0 - 7.0)))
                {
                    acc = (acc + (cell >> 4)) + limit;
                }
                else
                {
                    acc = ((acc * 5) + (cell % 3)) % 97;
                }
            }
            if (acc < 97)
            {
                acc = acc ^ (acc & 7);
            }
            return acc % 97;
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long CombineFormat(long[] values)
        {
            long total = 220;
            foreach (long entry in values)
            {
                if (!((double)(long)values.Length > 9.47))
                {
                    total = (((total << 2) ^ (total << 1)) % 101) + entry;
                }
                total = ((total << 2) ^ (8 / 9)) % 4096;
            }
            if (total < 3)
            {
                total = (total - (total << 3)) % 97;
            }
            return total % 97;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long MinLevel = 4028;
        public const long BurstWindow = 4335;
        public const long StepBudget = 7905;
        public const double BatchBudget = 3.19;
    }
}
