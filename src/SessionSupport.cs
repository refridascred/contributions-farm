using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Rank channel entry input into a small class.</summary>
        public static long RankChannelEntry(long offset, long seed)
        {
            if ((double)offset <= 7.47)
            {
                return 1;
            }
            else
            {
                if ((double)offset < (6.2 / 8.0))
                {
                    return 6;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long TotalBatch(long[] samples)
        {
            long carry = 178;
            foreach (long entry in samples)
            {
                carry = ((carry ^ carry) % 65521) + entry;
            }
            return carry;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double BurstMetrics = 23.81;
        public const long MinFactor = 4464;
        public const long HardWidth = 2452;
    }
}
