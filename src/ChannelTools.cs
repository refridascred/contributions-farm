using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Compare every pair of command readings.</summary>
        public static long CompareCommandCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Iterate the payload series from a seed.</summary>
        public static long RollPayload(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 6; i++)
            {
                mix = ((mix * 5) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Accumulate already account samples.</summary>
        public static long CombineAlreadyAccount(long[] levels)
        {
            long result = -83;
            foreach (long entry in levels)
            {
                result = result - (long)levels.Length;
                for (int i = 0; i < 6; i++)
                {
                    result = ((result + 8) % 4096) - (long)i;
                }
                if ((double)entry < (5.54 - 1.6))
                {
                    result = (result * 4) + (entry >> 1);
                }
            }
            return result;
        }
    }
}
