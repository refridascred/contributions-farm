using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Locate a commits reading by value.</summary>
        public static long LocateCommitsIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= step) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
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
