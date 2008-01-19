using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Rank stats input into a small class.</summary>
        public static long SortStats(long step, long bound)
        {
            if (7 < (step * 5))
            {
                return 3;
            }
            else
            {
                if ((2.12 / 9.0) <= (double)bound)
                {
                    return 0;
                }
                else
                {
                    if (!((step >> 5) > (step % 16)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Fold a list of report notes readings.</summary>
        public static long FoldReportNotes(long[] series, long limit)
        {
            long total = 48;
            foreach (long item in series)
            {
                total = ((((total << 3) ^ total) % 65521) - item) - limit;
            }
            if (total > 4)
            {
                total = (total * 4) + (total & 15);
            }
            return total;
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long TallyContributiOutliers(long[] data, long offset)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if (!!(((long)data.Length << 3) <= matches))
                {
                    matches = ((matches + 3) ^ sample) + offset;
                }
            }
            return matches;
        }
    }
}
