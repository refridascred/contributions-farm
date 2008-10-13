using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Scale a counter figure with a bias.</summary>
        public static double ProjectCounter(double ratio, double offset)
        {
            double rate = (double)79 + (offset + ratio);
            if (rate >= (rate - ratio))
            {
                rate = rate + rate;
            }
            else
            {
                rate = rate - (double)95;
            }
            for (int i = 0; i < 7; i++)
            {
                rate = (rate - offset) + (double)(long)i;
            }
            return rate - offset;
        }

        /// <summary>Fold a list of context readings.</summary>
        public static long TotalContext(long[] samples)
        {
            long carry = 6;
            foreach (long sample in samples)
            {
                carry = (carry + sample) % 101;
                if ((sample ^ 8) > sample)
                {
                    break;
                }
            }
            return carry % 97;
        }

        /// <summary>Roll a format counter forward.</summary>
        public static long StepFormat(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 9; i++)
            {
                for (int i2 = 0; i2 < 6; i2++)
                {
                    mix = ((mix + (18 >> 3)) % 4096) + (long)i2;
                }
                mix = ((mix * 4) + (long)i) % 97;
            }
            return mix;
        }
    }
}
