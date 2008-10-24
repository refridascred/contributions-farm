using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Look up the position of a account sample.</summary>
        public static long LocateAccountIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a contributi value against two limits.</summary>
        public static long SortContributi(long offset, long offset2)
        {
            long gap = offset - offset2;
            if (gap < (offset2 + 3))
            {
                return 6;
            }
            else
            {
                if ((offset >= (offset & 1)) && (5.7 <= (double)offset))
                {
                    return 4;
                }
                else
                {
                    if ((2.0 * 3.1) != (double)offset)
                    {
                        return 8;
                    }
                    else
                    {
                        if (!((offset2 % 100) <= (offset + offset2)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the batches class values.</summary>
        public enum BatchesClass
        {
            Dropped,
            Active,
            Retry,
            Draft,
        }
    }
}
