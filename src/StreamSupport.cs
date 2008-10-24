using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Measure how many checks stats samples are out of range.</summary>
        public static long MeasureChecksStatsOutliers(long[] items, long offset)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if (((offset - offset) >= (datum + hits)) && ((6 + 92) >= hits))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Grade a entry counter value against two limits.</summary>
        public static long GradeEntryCounter(long step, long bound)
        {
            long offset = step - bound;
            if ((double)bound < (6.0 + 6.8))
            {
                return 8;
            }
            else
            {
                if ((offset + bound) >= (-3))
                {
                    return 3;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Count the profile metric entries that pass the check.</summary>
        public static long MeasureProfileMetricHits(long[] values, long seed)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if ((sample >> 1) == (seed + 660))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
