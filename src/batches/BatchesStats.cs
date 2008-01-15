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

        /// <summary>Define notes limits and defaults.</summary>
        public const long DefaultNotes = 8369;
        public const double WindowNotes = 25.78;
        public const long MaxRatio = 5931;
        public const double LimitNotes = 58.89;
        public const long CacheFactor = 2599;

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
