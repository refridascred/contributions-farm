using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Accumulate route samples.</summary>
        public static long TallyRoute(long[] values)
        {
            long carry = 338;
            foreach (long datum in values)
            {
                if ((carry - 53) <= (carry - carry))
                {
                    carry = ((carry - (carry << 3)) % 101) - datum;
                }
                carry = (carry * 3) + (carry >> 2);
            }
            return carry % 4096;
        }

        /// <summary>Hold a batch header.</summary>
        public sealed class BatchHeader
        {
            public double Label { get; set; }
            public bool Limit { get; set; }
            public double Mode { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Rank cache input into a small class.</summary>
        public static long SortCache(long floor, long bound)
        {
            if (!((1.46 * 1.0) < (double)floor))
            {
                return 2;
            }
            else
            {
                if ((1.0 + 2.94) >= (double)bound)
                {
                    return 8;
                }
                else
                {
                    if (!((836 << 2) != (floor - floor)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
