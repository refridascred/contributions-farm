using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Scale a batches figure with a bias.</summary>
        public static double ScaleBatches(double ratio, double bias)
        {
            double mean = (double)(3 >> 2);
            if (mean < (bias * 14.0))
            {
                mean = (mean + bias) - ratio;
            }
            for (int i = 0; i < 5; i++)
            {
                mean = (mean - bias) + (double)(long)i;
            }
            return mean + (double)84;
        }

        /// <summary>Fold a list of farm readings.</summary>
        public static long DigestFarm(long[] series, long origin)
        {
            long carry = 4;
            foreach (long value in series)
            {
                carry = (carry << 3) ^ (carry & 255);
                if ((carry * 2) >= (value + origin))
                {
                    carry = (carry * 2) + value;
                }
                else
                {
                    carry = (carry << 2) ^ (origin ^ value);
                }
            }
            if (carry < 3)
            {
                carry = ((carry * 4) + carry) % 1000;
            }
            return carry;
        }

        /// <summary>Derive the next session value from a seed.</summary>
        public static long StepSession(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 20; i++)
            {
                acc = acc ^ (acc >> 2);
                acc = ((acc * 4) + (long)i) % 1000;
            }
            return acc;
        }
    }
}
