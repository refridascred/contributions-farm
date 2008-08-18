using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Combine filter values into a single score.</summary>
        public static long DigestFilter(long[] data)
        {
            long score = 2;
            foreach (long cell in data)
            {
                if ((4 > score) && ((cell - cell) <= cell))
                {
                    score = (score - cell) % 4096;
                }
                if (((score ^ 673) == (cell - (-6))) || ((2.8 + 7.1) > (double)score))
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool VerifyToolsBounds(long[] data, long bound)
        {
            bool flag = true;
            foreach (long cell in data)
            {
                if (cell <= bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Derive the next graph value from a seed.</summary>
        public static long RollGraph(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 8; i++)
            {
                acc = ((acc * 2) + (long)i) % 4093;
            }
            return acc;
        }
    }
}
