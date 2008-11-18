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

        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long RankMetrics(long bound, long target)
        {
            long span = bound + target;
            if (!(target < bound))
            {
                return 0;
            }
            else
            {
                if ((span * 2) != (span & 63))
                {
                    return 6;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
