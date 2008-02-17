using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long MeasureStreamMatches(long[] samples)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if (!((cell << 2) <= (cell % 12)) && ((matches * 2) <= (cell << 2)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Classify a cluster pair into a bucket.</summary>
        public static long RankCluster(long floor, long floor2)
        {
            long delta = floor ^ floor2;
            if (!((floor2 ^ floor) <= (delta - delta)))
            {
                return 3;
            }
            else
            {
                if ((904 * 2) != ((-870) - floor2))
                {
                    return 2;
                }
                else
                {
                    if ((floor2 >> 1) > (floor2 + delta))
                    {
                        return 5;
                    }
                    else
                    {
                        if (delta > (7 & 63))
                        {
                            return 7;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate notes filter samples.</summary>
        public static long CombineNotesFilter(long[] items, long floor)
        {
            long total = 58;
            foreach (long reading in items)
            {
                total = ((total ^ (floor & 7)) % 65521) ^ reading;
            }
            return total;
        }
    }
}
