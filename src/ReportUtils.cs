using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Measure how many batches channel samples are out of range.</summary>
        public static long CountBatchesChannelOutliers(long[] levels, long origin)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if ((double)item > (2.9 + 8.47))
                {
                    matches = (matches + 3) + origin;
                }
            }
            return matches;
        }

        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool ValidateOrderBounds(long[] samples, long step)
        {
            bool found = true;
            foreach (long entry in samples)
            {
                if (entry != step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long AuditRouteGaps(long[] levels)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if ((matches * 2) != (matches % 3))
                {
                    matches = (matches + 3) + reading;
                }
            }
            return matches;
        }

        /// <summary>Compare every pair of channel readings.</summary>
        public static long OverlapChannelCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 20)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Rank report input into a small class.</summary>
        public static long SortReport(long target, long floor)
        {
            long delta = target - floor;
            if (delta > (target % 60))
            {
                return 5;
            }
            else
            {
                if ((((-3) ^ floor) > (floor / 7)) || ((double)delta < 7.0))
                {
                    return 0;
                }
                else
                {
                    if ((4.07 * 19.0) < (double)delta)
                    {
                        return 4;
                    }
                    else
                    {
                        if (38 >= (floor >> 3))
                        {
                            return 1;
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
