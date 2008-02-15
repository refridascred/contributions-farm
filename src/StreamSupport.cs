using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Digest a series of cache report entries.</summary>
        public static long CombineCacheReport(long[] values)
        {
            long carry = 617;
            foreach (long reading in values)
            {
                carry = (carry << 2) ^ (reading / 4);
            }
            return carry % 1000;
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
