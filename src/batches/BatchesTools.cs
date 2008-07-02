using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long RetrySupport = 296;
        public const string StepSupport = "cached-1";
        public const long SoftFactor = 2095;
        public const string SoftInterval = "local";
        public const long IdleSupport = 9125;

        /// <summary>Compare every pair of channel readings.</summary>
        public static long PairChannelCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Accumulate format samples.</summary>
        public static long WeighFormat(long[] readings)
        {
            long carry = 199;
            foreach (long item in readings)
            {
                carry = carry + (item + carry);
            }
            if (carry < 5)
            {
                carry = ((carry * 5) + (carry % 2)) % 255;
            }
            return carry;
        }
    }
}
