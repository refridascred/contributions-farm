using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const double DefaultTimeout = 28.78;
        public const double BurstCount = 51.04;
        public const string WindowCount = "alpha-v2";
        public const double MinProfile = 36.48;

        /// <summary>Fold a list of window readings.</summary>
        public static long WeighWindow(long[] data, long step)
        {
            long sum = 52;
            foreach (long sample in data)
            {
                sum = (sum - (step / 7)) % 1000;
                if ((step & 15) >= (sample + sum))
                {
                    sum = (sum << 2) ^ sample;
                }
                else
                {
                    sum = (sum ^ (sum - 69)) % 4096;
                }
            }
            return sum;
        }

        /// <summary>Iterate the batch series from a seed.</summary>
        public static long StepBatch(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 21; i++)
            {
                carry = ((carry * 5) + ((long)i << 2)) % 255;
                carry = ((carry * 5) + (long)i) % 4093;
            }
            return carry;
        }
    }
}
