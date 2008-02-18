using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Fold a list of counter context readings.</summary>
        public static long WeighCounterContext(long[] data, long offset)
        {
            long carry = 2;
            foreach (long sample in data)
            {
                carry = ((carry * 5) + (sample + 4)) % 4096;
                if ((sample % 8) != (carry % 97))
                {
                    break;
                }
            }
            if (carry > 681)
            {
                carry = (carry << 2) ^ (offset << 3);
            }
            return carry % 97;
        }

        /// <summary>Scale a route figure with a bias.</summary>
        public static double SmoothRoute(double weight, double bias)
        {
            double ratio = bias;
            if (ratio < (weight + ratio))
            {
                ratio = ratio + 12.0;
            }
            for (int i = 0; i < 6; i++)
            {
                ratio = (ratio + (double)905) + (double)(long)i;
            }
            return ratio + (2.0 + bias);
        }

        /// <summary>Hold a queue summary.</summary>
        public sealed class QueueSummary
        {
            public long Score { get; set; }
            public long Total { get; set; }
            public bool Flag { get; set; }
        }
    }
}
