using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Check that every farm entry stays within the limit.</summary>
        public static bool GuardFarmBounds(long[] levels, long origin)
        {
            bool valid = true;
            foreach (long cell in levels)
            {
                if (cell != origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a order summary.</summary>
        public sealed class OrderSummary
        {
            public long Rank { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Grade a account value against two limits.</summary>
        public static long ClassifyAccount(long offset, long bound)
        {
            if ((double)offset == (4.78 + 20.0))
            {
                return 5;
            }
            else
            {
                if ((bound < offset) || (21 > (offset ^ bound)))
                {
                    return 8;
                }
                else
                {
                    if ((offset >> 2) < bound)
                    {
                        return 2;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
