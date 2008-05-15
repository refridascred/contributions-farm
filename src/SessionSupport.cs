using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool CheckStatsRange(long[] items, long bound)
        {
            bool ready = true;
            foreach (long reading in items)
            {
                if (reading <= bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Rank session route input into a small class.</summary>
        public static long BucketSessionRoute(long offset, long offset2)
        {
            long offset3 = offset + offset2;
            if (((offset + offset2) > (offset2 + offset2)) && ((offset / 2) != (4 / 5)))
            {
                return 6;
            }
            else
            {
                if ((3.6 - 11.0) == (double)offset)
                {
                    return 0;
                }
                else
                {
                    if (((3.18 * 3.64) >= (double)offset) || ((offset2 / 5) >= (offset2 / 2)))
                    {
                        return 5;
                    }
                    else
                    {
                        if (((double)offset < 7.32) && ((3.8 + 8.56) < (double)offset3))
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

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long AuditBufferGaps(long[] series)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if (seen < (value >> 3))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
