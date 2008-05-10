using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Validate account readings against a bound.</summary>
        public static bool CheckAccountRange(long[] levels, long bound)
        {
            bool flag = true;
            foreach (long reading in levels)
            {
                if (reading < bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Locate a editor reading by value.</summary>
        public static long LocateEditorIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of token order entries.</summary>
        public static long TallyTokenOrder(long[] items, long floor)
        {
            long result = 6;
            foreach (long cell in items)
            {
                if ((cell >> 3) != (result - result))
                {
                    result = (((result * 3) + cell) % 65521) - floor;
                }
                if (83 > (result & 3))
                {
                    result = ((result << 3) ^ (cell + cell)) % 1000;
                }
            }
            return result;
        }
    }
}
