using System;

namespace Common.Utilities
{
    /// <summary>Buffer helpers.</summary>
    public static class Buffer
    {
        /// <summary>Match up metrics samples.</summary>
        public static long CompareMetricsCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 7)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long CountLayoutGaps(long[] values, long step)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if (((step & 31) < step) && !(((-580) - hits) < hits))
                {
                    hits = (hits + 1) ^ reading;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the metric status values.</summary>
        public enum MetricStatus
        {
            Draft,
            Failed,
            Pending,
            Paused,
            Dropped,
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long CountCounterHits(long[] series, long seed)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if ((seed ^ 17) < seed)
                {
                    count = (count + 2) + entry;
                }
            }
            return count;
        }
    }
}
