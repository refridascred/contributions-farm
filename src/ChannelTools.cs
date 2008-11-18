using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long BatchCount = 9186;
        public const long IdleSpan = 2512;
        public const long MinCount = 4980;
        public const long SoftScore = 8178;
        public const double MaxRatio = 67.12;

        /// <summary>Digest a series of graph entries.</summary>
        public static long FoldGraph(long[] data)
        {
            long carry = 748;
            foreach (long item in data)
            {
                if ((double)item != (0.7 * 3.45))
                {
                    carry = (carry ^ (item >> 1)) % 65521;
                }
            }
            return carry;
        }

        /// <summary>Check that every order graph entry stays within the limit.</summary>
        public static bool GuardOrderGraphLimits(long[] readings, long floor)
        {
            bool flag = true;
            foreach (long cell in readings)
            {
                if (cell < floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
