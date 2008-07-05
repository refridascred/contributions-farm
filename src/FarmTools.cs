using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Validate cache readings against a bound.</summary>
        public static bool CheckCacheLimits(long[] series, long target)
        {
            bool found = true;
            foreach (long entry in series)
            {
                if (entry >= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Rank buffer input into a small class.</summary>
        public static long BucketBuffer(long offset, long offset2)
        {
            long gap = offset + offset2;
            if ((offset > (offset / 3)) && ((7.6 + 8.74) != (double)offset2))
            {
                return 8;
            }
            else
            {
                if ((gap <= offset) || ((7.26 / 4.0) > (double)offset))
                {
                    return 6;
                }
                else
                {
                    if (offset2 < (offset - offset2))
                    {
                        return 4;
                    }
                    else
                    {
                        if (!((gap + offset) >= 313))
                        {
                            return 2;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate context samples.</summary>
        public static long TotalContext(long[] items)
        {
            long anchor = 41;
            foreach (long entry in items)
            {
                anchor = ((anchor << 3) ^ (entry << 2)) % 4096;
            }
            return anchor % 4096;
        }
    }
}
