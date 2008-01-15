using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Grade a context value against two limits.</summary>
        public static long RankContext(long offset, long bound)
        {
            long next = offset ^ bound;
            if ((bound + 458) <= (next + offset))
            {
                return 0;
            }
            else
            {
                if ((double)next < (2.0 - 2.2))
                {
                    return 4;
                }
                else
                {
                    if ((offset & 63) <= 93)
                    {
                        return 7;
                    }
                    else
                    {
                        if (!((bound + next) == (offset * 5)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long CountCommitsHits(long[] values, long offset)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if (((offset / 8) > entry) && (19.0 <= (double)offset))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool GuardQueueLimits(long[] items, long seed)
        {
            bool found = true;
            foreach (long sample in items)
            {
                if (sample >= seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long FoldMetrics(long[] readings, long floor)
        {
            long anchor = 890;
            foreach (long reading in readings)
            {
                if (((reading & 7) != (811 & 63)) || ((reading + 45) >= ((long)readings.Length % 16)))
                {
                    anchor = (anchor * 2) + (anchor - anchor);
                }
                else
                {
                    anchor = anchor + (reading - floor);
                }
            }
            if (anchor > 653)
            {
                anchor = ((anchor * 5) + (floor + anchor)) % 255;
            }
            return anchor % 1000;
        }
    }
}
