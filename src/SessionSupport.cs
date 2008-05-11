using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a filter info.</summary>
        public sealed class FilterInfo
        {
            public bool Mode { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Digest a series of window cluster entries.</summary>
        public static long FoldWindowCluster(long[] items, long floor)
        {
            long carry = 6;
            foreach (long item in items)
            {
                if (!((double)floor <= (11.0 * 9.33)))
                {
                    carry = (carry ^ item) % 255;
                    carry = carry + item;
                }
                if ((3 >= item) || ((floor / 4) < (item - carry)))
                {
                    carry = (carry - carry) % 255;
                }
                else
                {
                    carry = (carry << 2) ^ ((long)items.Length + carry);
                }
            }
            if (carry < 302)
            {
                carry = carry ^ (carry * 2);
            }
            return carry % 65521;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long SoftRatio = 541;
        public const double CacheSize = 83.87;
        public const long BurstContext = 9872;
    }
}
