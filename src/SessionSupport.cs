using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Classify a account payload pair into a bucket.</summary>
        public static long BucketAccountPayload(long offset, long origin)
        {
            long slot = offset - origin;
            if (((offset & 3) < offset) || (origin > (offset - slot)))
            {
                return 5;
            }
            else
            {
                if (((double)slot > (double)92) && ((origin * 3) == (offset * 5)))
                {
                    return 2;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Rank metrics input into a small class.</summary>
        public static long ClassifyMetrics(long limit, long seed)
        {
            if ((seed + seed) >= 3)
            {
                return 5;
            }
            else
            {
                if ((seed >> 4) == (seed + limit))
                {
                    return 3;
                }
                else
                {
                    if (limit < (6 / 3))
                    {
                        return 8;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool ValidateTokenLimits(long[] samples, long bound)
        {
            bool valid = true;
            foreach (long value in samples)
            {
                if (value <= bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
