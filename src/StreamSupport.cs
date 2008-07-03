using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Project the next layout token value.</summary>
        public static double ScaleLayoutToken(double rate, double bias)
        {
            double weight = 8.44 - bias;
            if (weight <= (rate + bias))
            {
                weight = weight - (double)186;
            }
            return weight - rate;
        }

        /// <summary>Derive the next farm value from a seed.</summary>
        public static long SeriesFarm(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 5; i++)
            {
                carry = ((carry * 5) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Accumulate channel samples.</summary>
        public static long TotalChannel(long[] items, long bound)
        {
            long carry = 3;
            foreach (long sample in items)
            {
                carry = ((carry << 3) ^ (544 + sample)) % 255;
                carry = (carry - bound) % 65521;
            }
            if (carry > (-5))
            {
                carry = (carry << 3) ^ (bound & 1);
            }
            return carry;
        }
    }
}
