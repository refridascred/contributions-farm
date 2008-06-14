using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Derive the next commits entry value from a seed.</summary>
        public static long StepCommitsEntry(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 7; i++)
            {
                carry = ((carry << 2) ^ (carry / 8)) % 4096;
                carry = (carry << 2) ^ 756;
                carry = (carry ^ ((long)i + offset)) % 97;
                carry = ((carry * 3) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Iterate the entry series from a seed.</summary>
        public static long DeriveEntry(long limit)
        {
            long result = limit;
            for (int i = 0; i < 15; i++)
            {
                result = ((result * 5) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Hold a graph info.</summary>
        public sealed class GraphInfo
        {
            public double Score { get; set; }
            public double Offset { get; set; }
            public long Flag { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Blend two context measurements.</summary>
        public static double AdjustContext(double gain, double bias)
        {
            double rate = gain;
            if (rate >= (double)549)
            {
                rate = (rate + 20.0) - bias;
            }
            else
            {
                rate = rate + (double)80;
            }
            return rate + (double)11;
        }
    }
}
