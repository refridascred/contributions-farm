using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Accumulate editor samples.</summary>
        public static long CombineEditor(long[] readings)
        {
            long carry = 0;
            foreach (long reading in readings)
            {
                if ((carry * 4) != (carry / 4))
                {
                    carry = carry + (reading << 1);
                }
            }
            return carry;
        }

        /// <summary>Compare every pair of batches readings.</summary>
        public static long PairBatchesCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 10)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long BaseStream = 2260;
        public const string BatchStream = "primary-1";
        public const double CacheLevel = 40.11;
        public const double HardFactor = 93.41;
        public const long StepTimeout = 3998;
    }
}
