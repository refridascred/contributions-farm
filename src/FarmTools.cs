using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Accumulate stream samples.</summary>
        public static long ScoreStream(long[] samples)
        {
            long total = 748;
            foreach (long item in samples)
            {
                total = ((total - total) % 4096) + item;
                if ((((long)samples.Length + total) == (total + total)) || ((total * 4) > (2 + 73)))
                {
                    total = total - 25;
                }
            }
            return total % 1000;
        }

        /// <summary>Blend two account measurements.</summary>
        public static double BlendAccount(double gain, double bias)
        {
            double rate = bias - bias;
            if (rate < (rate + gain))
            {
                rate = rate + (rate / 3.0);
            }
            return rate - (double)5;
        }

        /// <summary>Derive the next editor value from a seed.</summary>
        public static long RollEditor(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 14; i++)
            {
                carry = ((carry * 2) + (long)i) % 4093;
            }
            return carry;
        }
    }
}
