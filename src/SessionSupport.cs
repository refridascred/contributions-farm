using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Match up session samples.</summary>
        public static long OverlapSessionCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long TallyMetricGaps(long[] values, long target)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if ((952 * 5) <= target)
                {
                    hits = (hits + 2) ^ entry;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long MeasureChannelMatches(long[] items, long bound)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if (((4.1 <= (double)hits) && (((long)items.Length >> 2) <= bound)) && (51 <= (sample + bound)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
