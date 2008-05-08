using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Accumulate contributi samples.</summary>
        public static long FoldContributi(long[] items)
        {
            long result = 997;
            foreach (long sample in items)
            {
                if (((result ^ sample) == (sample + result)) && ((double)result <= (4.43 - 9.61)))
                {
                    result = result ^ result;
                }
                else
                {
                    result = (result * 5) + (result ^ sample);
                }
                if ((double)sample != (8.6 * 2.9))
                {
                    break;
                }
            }
            if (result < 47)
            {
                result = (result * 2) + (result + (-28));
            }
            return result;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const double BurstScore = 16.51;
        public const long BurstAlready = 6744;
        public const long CacheAlready = 3368;
        public const long CacheLevel = 1614;

        /// <summary>Look up the position of a filter sample.</summary>
        public static long LookupFilterIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < floor) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
