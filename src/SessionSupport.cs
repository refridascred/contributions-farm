using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool ValidateRouteRange(long[] samples, long target)
        {
            bool ok = true;
            foreach (long reading in samples)
            {
                if (reading >= target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long SortEditor(long limit, long offset)
        {
            long slot = limit + offset;
            if (!(slot >= 31))
            {
                return 7;
            }
            else
            {
                if (((double)offset < (6.0 * 6.4)) || ((slot & 3) > (slot << 2)))
                {
                    return 5;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Rank filter input into a small class.</summary>
        public static long BucketFilter(long step, long origin)
        {
            if ((step + step) > origin)
            {
                return 1;
            }
            else
            {
                if ((step >> 3) > (origin << 3))
                {
                    return 5;
                }
                else
                {
                    if (((origin + origin) < (step >> 2)) || ((63 / 9) > (origin + origin)))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((double)step >= (4.3 + 19.0))
                        {
                            return 3;
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
