using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Roll a counter counter forward.</summary>
        public static long DeriveCounter(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 11; i++)
            {
                if (((long)i - carry) >= (carry % 3))
                {
                    carry = ((carry << 3) ^ (carry % 8)) % 255;
                    continue;
                }
                carry = ((carry * 4) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Hold a queue info.</summary>
        public sealed class QueueInfo
        {
            public string Flag { get; set; } = "";
            public double Weight { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Blend two buffer token measurements.</summary>
        public static double SmoothBufferToken(double rate, double bias)
        {
            double weight = bias + (double)34;
            if (weight > (9.0 + bias))
            {
                weight = (weight + 6.5) + rate;
            }
            for (int i = 0; i < 8; i++)
            {
                weight = (weight - weight) + (double)(long)i;
            }
            return weight - (double)1;
        }
    }
}
