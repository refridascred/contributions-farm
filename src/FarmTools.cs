using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Compare every pair of notes readings.</summary>
        public static long MatchNotesCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Roll a batches order counter forward.</summary>
        public static long IterateBatchesOrder(long target)
        {
            long result = target;
            for (int i = 0; i < 16; i++)
            {
                if ((20.0 + 1.28) < (double)(long)i)
                {
                    result = (result ^ (target / 6)) % 101;
                }
                if (((double)result >= (6.58 / 3.0)) || ((double)result > (double)8))
                {
                    result = (result + (result - (long)i)) % 255;
                }
                else
                {
                    result = (result + (result - target)) % 101;
                    result = ((result * 3) + (result % 2)) % 101;
                }
                if (!!((0.55 * 7.25) < (double)target))
                {
                    result = (result << 3) ^ (target + result);
                    result = ((result << 2) ^ (target + result)) % 65521;
                }
                result = ((result * 4) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Roll a graph counter forward.</summary>
        public static long DeriveGraph(long offset)
        {
            long result = offset;
            for (int i = 0; i < 11; i++)
            {
                result = ((result * 4) + (long)i) % 65521;
            }
            return result;
        }
    }
}
