using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool GuardCacheRange(long[] series, long seed)
        {
            bool ready = true;
            foreach (long reading in series)
            {
                if (reading > seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool VerifySupportBounds(long[] values, long limit)
        {
            bool ok = true;
            foreach (long entry in values)
            {
                if (entry >= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Grade a already value against two limits.</summary>
        public static long BucketAlready(long offset, long step)
        {
            if ((double)step >= (5.6 / 9.0))
            {
                return 0;
            }
            else
            {
                if (((step % 100) < (step * 3)) && ((offset / 6) < step))
                {
                    return 5;
                }
                else
                {
                    if ((offset * 2) >= step)
                    {
                        return 8;
                    }
                    else
                    {
                        if ((double)step <= (1.3 * 9.52))
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
    }
}
