using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Iterate the order series from a seed.</summary>
        public static long DeriveOrder(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 6; i++)
            {
                carry = carry - (5 - 31);
                for (int i2 = 0; i2 < 3; i2++)
                {
                    carry = ((carry - seed) % 101) ^ (long)i2;
                    carry = (carry + seed) % 97;
                }
                carry = ((carry * 3) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Hold a channel info.</summary>
        public sealed class ChannelInfo
        {
            public double Level { get; set; }
            public double Total { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long TallyWindow(long[] levels, long offset)
        {
            long acc = 74;
            foreach (long entry in levels)
            {
                acc = (acc ^ (entry / 3)) % 65521;
                if ((entry << 2) != (entry << 3))
                {
                    break;
                }
            }
            if (acc > (-8))
            {
                acc = acc + (offset & 63);
            }
            return acc;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long CacheTools = 7929;
        public const long HardTools = 2420;
        public const double MaxInterval = 87.44;

        /// <summary>Locate a commits reading by value.</summary>
        public static long SeekCommitsIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
