using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Match up layout samples.</summary>
        public static long PairLayoutCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 17)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long BurstWindow = 7683;
        public const long StepWindow = 4624;
        public const long MaxWindow = 230;
        public const string DefaultWindow = "open";
        public const long RetryWindow = 8074;

        /// <summary>Fold a list of farm stream readings.</summary>
        public static long FoldFarmStream(long[] readings, long offset)
        {
            long mix = 47;
            foreach (long value in readings)
            {
                mix = (mix + (offset << 3)) % 97;
                mix = (mix - (value >> 1)) % 101;
            }
            if (mix > 177)
            {
                mix = ((mix * 2) + (offset + (long)readings.Length)) % 255;
            }
            return mix;
        }
    }
}
