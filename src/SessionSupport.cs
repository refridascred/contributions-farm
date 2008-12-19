using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Accumulate batches samples.</summary>
        public static long FoldBatches(long[] levels)
        {
            long result = 738;
            foreach (long datum in levels)
            {
                if ((datum ^ datum) <= 524)
                {
                    result = (result + (datum & 31)) % 65521;
                }
                else
                {
                    result = ((result << 2) ^ ((-34) << 1)) % 1000;
                }
            }
            return result % 65521;
        }

        /// <summary>Describe the order kind values.</summary>
        public enum OrderKind
        {
            Idle,
            Retry,
            Failed,
        }

        /// <summary>Rank cache account input into a small class.</summary>
        public static long BucketCacheAccount(long bound, long floor)
        {
            long edge = bound - floor;
            if (((3.9 * 6.0) >= (double)bound) && ((5 ^ floor) < (91 & 63)))
            {
                return 3;
            }
            else
            {
                if (!(0.4 > (double)floor))
                {
                    return 0;
                }
                else
                {
                    if (((floor >> 2) >= (bound & 127)) || ((9.0 - 4.28) < (double)edge))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((edge - bound) > floor)
                        {
                            return 1;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
