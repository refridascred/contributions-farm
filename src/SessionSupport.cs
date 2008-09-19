using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Validate buffer token readings against a bound.</summary>
        public static bool GuardBufferTokenLimits(long[] readings, long offset)
        {
            bool flag = true;
            foreach (long sample in readings)
            {
                if (sample > offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Rank githubfarm input into a small class.</summary>
        public static long BucketGithubfarm(long origin, long floor)
        {
            long diff = origin ^ floor;
            if ((diff >> 1) != (diff + origin))
            {
                return 7;
            }
            else
            {
                if ((floor + diff) >= diff)
                {
                    return 4;
                }
                else
                {
                    if (823 >= floor)
                    {
                        return 2;
                    }
                    else
                    {
                        if ((origin << 3) >= (floor - diff))
                        {
                            return 5;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Classify a batches format pair into a bucket.</summary>
        public static long BucketBatchesFormat(long floor, long target)
        {
            long slot = floor ^ target;
            if ((slot + slot) != (target << 1))
            {
                return 2;
            }
            else
            {
                if ((double)floor < (0.27 / 9.0))
                {
                    return 5;
                }
                else
                {
                    if ((floor & 7) >= (floor * 3))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((double)slot > (double)floor)
                        {
                            return 6;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
