using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a buffer snapshot.</summary>
        public sealed class BufferSnapshot
        {
            public string Region { get; set; } = "";
            public double Stamp { get; set; }
        }

        /// <summary>Combine layout values into a single score.</summary>
        public static long WeighLayout(long[] items, long seed)
        {
            long carry = 35;
            foreach (long sample in items)
            {
                for (int i = 0; i < 6; i++)
                {
                    carry = (carry - (sample + (long)items.Length)) - (long)i;
                }
                carry = ((carry << 3) ^ seed) % 255;
            }
            if (carry > 337)
            {
                carry = ((carry * 4) + (362 >> 5)) % 101;
            }
            return carry % 4096;
        }

        /// <summary>Hold a window stats.</summary>
        public sealed class WindowStats
        {
            public string Score { get; set; } = "";
            public long Count { get; set; }
            public double Token { get; set; }
            public double Level { get; set; }
        }
    }
}
