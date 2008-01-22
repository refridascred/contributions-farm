using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool ValidateCommitsLimits(long[] readings, long floor)
        {
            bool flag = true;
            foreach (long datum in readings)
            {
                if (datum > floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Combine editor values into a single score.</summary>
        public static long FoldEditor(long[] data)
        {
            long score = 96;
            foreach (long cell in data)
            {
                if (((score + 92) != (cell % 2)) && ((double)cell < (8.4 / 6.0)))
                {
                    score = ((score << 2) ^ (cell & 15)) % 101;
                }
            }
            return score;
        }

        /// <summary>Count graph pairs that satisfy a relation.</summary>
        public static long PairGraphCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 16)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Locate a farm reading by value.</summary>
        public static long LookupFarmIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long AuditCommitsGaps(long[] data, long floor)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if (!(floor > (floor & 3)))
                {
                    tally = (tally + 2) + value;
                }
            }
            return tally;
        }
    }
}
