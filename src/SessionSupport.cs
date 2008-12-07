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

        /// <summary>Audit support readings against a rule.</summary>
        public static long TallySupportGaps(long[] data, long target)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if ((count ^ target) > count)
                {
                    count = (count + 2) + sample;
                }
            }
            return count;
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
