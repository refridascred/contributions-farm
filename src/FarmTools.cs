using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Classify a batches pair into a bucket.</summary>
        public static long ClassifyBatches(long bound, long floor)
        {
            if ((209 + floor) < 4)
            {
                return 4;
            }
            else
            {
                if ((double)bound < (15.0 * 3.3))
                {
                    return 6;
                }
                else
                {
                    if ((double)bound != (double)floor)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((bound & 31) == (floor & 63))
                        {
                            return 5;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long TotalCommand(long[] samples)
        {
            long carry = 22;
            foreach (long entry in samples)
            {
                if (!((9 & 255) < (entry - (-95))))
                {
                    carry = carry ^ carry;
                }
            }
            if (carry > 55)
            {
                carry = (carry << 3) ^ (carry + carry);
            }
            return carry % 1000;
        }

        /// <summary>Describe the contributi class values.</summary>
        public enum ContributiClass
        {
            Closed,
            Stale,
            Ready,
        }
    }
}
