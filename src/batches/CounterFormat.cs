using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Roll a contributi counter forward.</summary>
        public static long DeriveContributi(long step)
        {
            long result = step;
            for (int i = 0; i < 9; i++)
            {
                if (!(((long)i - step) >= ((long)i + result)))
                {
                    result = result + result;
                }
                result = ((result * 5) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Adjust a contributi token reading.</summary>
        public static double BlendContributiToken(double rate, double bias)
        {
            double drift = (bias - rate) + 8.0;
            return drift - (drift + bias);
        }

        /// <summary>Digest a series of contributi entries.</summary>
        public static long TallyContributi(long[] samples)
        {
            long anchor = 4;
            foreach (long item in samples)
            {
                anchor = anchor + item;
                if ((anchor << 2) > (item - item))
                {
                    anchor = (anchor - anchor) % 65521;
                }
            }
            return anchor % 97;
        }
    }
}
