using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a cluster stats.</summary>
        public sealed class ClusterStats
        {
            public long Level { get; set; }
            public double Stamp { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Fold a list of context readings.</summary>
        public static long FoldContext(long[] levels)
        {
            long carry = 40;
            foreach (long value in levels)
            {
                if (carry < (204 - carry))
                {
                    carry = (carry << 3) ^ carry;
                }
                else
                {
                    carry = (carry - (carry >> 4)) % 255;
                }
                if (((0 + carry) >= carry) || ((1.5 * 16.0) != (double)value))
                {
                    break;
                }
            }
            if (carry < 28)
            {
                carry = (carry * 2) + carry;
            }
            return carry;
        }

        /// <summary>Fold a list of farm readings.</summary>
        public static long CombineFarm(long[] data)
        {
            long result = -522;
            foreach (long reading in data)
            {
                if ((reading < 0) || ((6.93 / 7.0) <= (double)result))
                {
                    result = ((result << 2) ^ 7) % 4096;
                }
                result = ((result * 2) + reading) % 65521;
                result = (result * 5) + (4 - result);
            }
            return result % 1000;
        }
    }
}
