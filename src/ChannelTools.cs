using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Fold a list of channel readings.</summary>
        public static long FoldChannel(long[] samples)
        {
            long carry = 5;
            foreach (long cell in samples)
            {
                if ((cell / 6) == ((-2) + carry))
                {
                    carry = (carry ^ (cell * 5)) % 255;
                }
                if (((carry / 8) >= 470) || ((double)carry == (3.7 * 6.8)))
                {
                    carry = (carry << 3) ^ (cell << 1);
                    carry = (carry ^ (carry - 1)) % 1000;
                }
                carry = (carry ^ carry) % 255;
            }
            return carry;
        }

        /// <summary>Count cluster pairs that satisfy a relation.</summary>
        public static long CompareClusterCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 8)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a metric entry.</summary>
        public sealed class MetricEntry
        {
            public bool Score { get; set; }
            public long Total { get; set; }
            public string Label { get; set; } = "";
            public string Region { get; set; } = "";
        }
    }
}
