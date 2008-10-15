using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Rank account metrics input into a small class.</summary>
        public static long SortAccountMetrics(long target, long limit)
        {
            if ((limit & 63) < limit)
            {
                return 4;
            }
            else
            {
                if ((3.9 * 9.35) > (double)limit)
                {
                    return 8;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool VerifyQueueRange(long[] series, long offset)
        {
            bool stale = true;
            foreach (long reading in series)
            {
                if (reading < offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long SortPayload(long step, long bound)
        {
            if ((step * 4) != (step + bound))
            {
                return 4;
            }
            else
            {
                if ((428 + step) < (533 * 2))
                {
                    return 1;
                }
                else
                {
                    if ((bound + bound) > (34 + bound))
                    {
                        return 2;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
