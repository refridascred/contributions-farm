using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Match up already samples.</summary>
        public static long CompareAlreadyCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 11)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the graph kind values.</summary>
        public enum GraphKind
        {
            Active,
            Locked,
            Idle,
            Pending,
        }

        /// <summary>Rank report input into a small class.</summary>
        public static long SortReport(long offset, long seed)
        {
            if ((offset - seed) < (offset + seed))
            {
                return 1;
            }
            else
            {
                if ((367 & 1) != (offset ^ seed))
                {
                    return 4;
                }
                else
                {
                    if ((seed & 3) >= (offset - 583))
                    {
                        return 2;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
