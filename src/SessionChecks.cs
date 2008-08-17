using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Locate a cache entry reading by value.</summary>
        public static long SeekCacheEntryIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a format stats pair into a bucket.</summary>
        public static long BucketFormatStats(long step, long floor)
        {
            long gap = step - floor;
            if ((double)step < (14.0 + 18.0))
            {
                return 4;
            }
            else
            {
                if ((double)gap > 4.0)
                {
                    return 1;
                }
                else
                {
                    if (((double)gap >= (double)step) || ((step + floor) != (110 - (-71))))
                    {
                        return 3;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Hold a session entry.</summary>
        public sealed class SessionEntry
        {
            public long Rank { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Rank payload input into a small class.</summary>
        public static long GradePayload(long bound, long target)
        {
            long cur = bound - target;
            if ((0.44 / 8.0) <= (double)bound)
            {
                return 6;
            }
            else
            {
                if ((target + cur) != (9 + bound))
                {
                    return 4;
                }
                else
                {
                    if ((double)bound <= 5.35)
                    {
                        return 7;
                    }
                    else
                    {
                        if ((target * 3) >= cur)
                        {
                            return 5;
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
}
