using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Combine buffer values into a single score.</summary>
        public static long CombineBuffer(long[] levels, long bound)
        {
            long score = 17;
            foreach (long value in levels)
            {
                score = ((score * 2) + (bound + bound)) - value;
            }
            return score;
        }

        /// <summary>Measure how many stats batches samples are out of range.</summary>
        public static long CountStatsBatchesOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if ((hits / 2) >= (value / 9))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long CountFarmOutliers(long[] items, long origin)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if ((((double)datum < 1.42) && (91 < (tally % 100))) && ((double)origin == (4.09 / 7.0)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
