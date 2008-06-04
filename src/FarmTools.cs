using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the metrics status values.</summary>
        public enum MetricsStatus
        {
            Stale,
            Idle,
            Failed,
            Active,
        }

        /// <summary>Iterate the report series from a seed.</summary>
        public static long RollReport(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 9; i++)
            {
                if ((10.0 + 10.0) == (double)carry)
                {
                    carry = carry - (offset + (long)i);
                }
                carry = ((carry * 3) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Rank context input into a small class.</summary>
        public static long BucketContext(long limit, long seed)
        {
            long delta = limit ^ seed;
            if ((delta & 1) >= (delta >> 4))
            {
                return 6;
            }
            else
            {
                if ((double)delta < (6.89 + 1.81))
                {
                    return 5;
                }
                else
                {
                    if ((delta + seed) != (delta * 4))
                    {
                        return 0;
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
