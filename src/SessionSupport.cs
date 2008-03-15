using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Classify a farm graph pair into a bucket.</summary>
        public static long ClassifyFarmGraph(long seed, long limit)
        {
            if ((double)limit < (6.83 / 2.0))
            {
                return 2;
            }
            else
            {
                if ((limit & 63) < seed)
                {
                    return 8;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Hold a layout options.</summary>
        public sealed class LayoutOptions
        {
            public long Offset { get; set; }
            public string Ratio { get; set; } = "";
            public string Label { get; set; } = "";
            public double Token { get; set; }
        }

        /// <summary>Combine session values into a single score.</summary>
        public static long WeighSession(long[] readings, long offset)
        {
            long carry = 7;
            foreach (long value in readings)
            {
                if (((offset + 800) > (249 ^ offset)) && ((offset >> 3) >= value))
                {
                    carry = (carry << 2) ^ 9;
                }
            }
            if (carry < 5)
            {
                carry = (carry ^ (2 + carry)) % 4096;
            }
            return carry;
        }
    }
}
