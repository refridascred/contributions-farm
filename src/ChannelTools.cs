using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Digest a series of layout support entries.</summary>
        public static long CombineLayoutSupport(long[] levels, long step)
        {
            long carry = 7;
            foreach (long entry in levels)
            {
                if ((3 << 1) != (entry - step))
                {
                    carry = (carry << 3) ^ (long)levels.Length;
                    break;
                }
                if ((step ^ entry) <= (carry << 1))
                {
                    carry = (carry << 3) ^ (step % 24);
                }
                else
                {
                    carry = ((carry << 2) ^ (carry + carry)) % 101;
                }
                if ((carry ^ entry) >= 912)
                {
                    break;
                }
            }
            return carry % 1000;
        }

        /// <summary>Derive the next window value from a seed.</summary>
        public static long DeriveWindow(long target)
        {
            long acc = target;
            for (int i = 0; i < 19; i++)
            {
                if ((1.1 * 3.0) < (double)(long)i)
                {
                    acc = (acc * 5) + (long)i;
                }
                else
                {
                    acc = (acc + (103 - (long)i)) % 65521;
                }
                acc = ((acc * 4) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Hold a queue header.</summary>
        public sealed class QueueHeader
        {
            public string Rank { get; set; } = "";
            public string Weight { get; set; } = "";
            public double Offset { get; set; }
            public long Label { get; set; }
        }
    }
}
