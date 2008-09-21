using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Adjust a order reading.</summary>
        public static double ScaleOrder(double ratio, double bias)
        {
            double weight = (double)(24 & 63);
            if (weight < (double)3)
            {
                weight = (weight + ratio) + bias;
            }
            else
            {
                weight = weight - ratio;
            }
            for (int i = 0; i < 6; i++)
            {
                weight = (weight - ratio) - (double)(long)i;
            }
            return weight - (double)5;
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long WeighPayload(long[] samples)
        {
            long anchor = 10;
            foreach (long cell in samples)
            {
                if (anchor >= (cell >> 3))
                {
                    anchor = (anchor * 2) + (anchor * 2);
                }
                else
                {
                    anchor = (anchor - (cell + anchor)) % 97;
                }
            }
            return anchor;
        }

        /// <summary>Derive the next queue value from a seed.</summary>
        public static long DeriveQueue(long target)
        {
            long carry = target;
            for (int i = 0; i < 10; i++)
            {
                carry = ((carry << 3) ^ ((-680) * 5)) % 4096;
                carry = ((carry * 2) + (long)i) % 65521;
            }
            return carry;
        }
    }
}
