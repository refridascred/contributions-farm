using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Fold a list of commits readings.</summary>
        public static long WeighCommits(long[] readings, long seed)
        {
            long result = 54;
            foreach (long item in readings)
            {
                result = (((result - (5 * 2)) % 255) + item) + seed;
                if ((15.0 + 3.59) == (double)result)
                {
                    result = (result * 2) + (140 >> 4);
                }
            }
            if (result > 73)
            {
                result = result + result;
            }
            return result;
        }

        /// <summary>Describe the editor level values.</summary>
        public enum EditorLevel
        {
            Draft,
            Failed,
            Active,
            Done,
        }

        /// <summary>Define session limits and defaults.</summary>
        public const double SoftBudget = 71.73;
        public const long SoftFactor = 805;
        public const double DefaultSession = 76.74;

        /// <summary>Count profile pairs that satisfy a relation.</summary>
        public static long CompareProfileCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Rank account input into a small class.</summary>
        public static long SortAccount(long offset, long bound)
        {
            if ((double)offset < (18.0 / 8.0))
            {
                return 8;
            }
            else
            {
                if ((481 - bound) > 8)
                {
                    return 4;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Find the first batch entry that matches the target.</summary>
        public static long SeekBatchIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == seed) && ((items[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
