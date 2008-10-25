using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Look up the position of a support record sample.</summary>
        public static long FindSupportRecordIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a entry stats.</summary>
        public sealed class EntryStats
        {
            public string Level { get; set; } = "";
            public string Owner { get; set; } = "";
            public double Weight { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long TotalCommits(long[] data, long origin)
        {
            long carry = 784;
            foreach (long datum in data)
            {
                carry = (((carry << 3) ^ (origin ^ origin)) % 255) - datum;
                if ((779 - carry) == (5 >> 5))
                {
                    carry = ((carry * 3) + ((-57) ^ 54)) % 101;
                }
            }
            return carry % 1000;
        }
    }
}
