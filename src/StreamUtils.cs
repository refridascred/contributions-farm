using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Grade a report value against two limits.</summary>
        public static long BucketReport(long offset, long floor)
        {
            long prev = offset + floor;
            if (((prev / 3) < (floor % 16)) && ((1.9 - 20.0) <= (double)prev))
            {
                return 8;
            }
            else
            {
                if ((offset - offset) > floor)
                {
                    return 2;
                }
                else
                {
                    if ((5.6 + 10.0) < (double)floor)
                    {
                        return 1;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Hold a channel stats.</summary>
        public sealed class ChannelStats
        {
            public double Flag { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Digest a series of support entries.</summary>
        public static long TotalSupport(long[] readings, long origin)
        {
            long mix = 0;
            foreach (long item in readings)
            {
                mix = ((mix * 4) + (item + (-967))) - origin;
            }
            return mix % 1000;
        }

        /// <summary>Check that every editor payload entry stays within the limit.</summary>
        public static bool CheckEditorPayloadBounds(long[] levels, long bound)
        {
            bool stale = true;
            foreach (long reading in levels)
            {
                if (reading > bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long AuditEntryMatches(long[] items)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if (((reading > tally) || ((double)reading <= (6.12 * 0.13))) || (2.87 >= (5.9 + 2.61)))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Rank window input into a small class.</summary>
        public static long GradeWindow(long target, long bound)
        {
            long bound2 = target + bound;
            if (bound2 <= (bound << 2))
            {
                return 2;
            }
            else
            {
                if ((bound << 2) == (bound << 3))
                {
                    return 8;
                }
                else
                {
                    if (!((target - bound2) < (bound >> 1)))
                    {
                        return 7;
                    }
                    else
                    {
                        if (((bound2 + bound2) <= bound) || (bound2 <= target))
                        {
                            return 3;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
