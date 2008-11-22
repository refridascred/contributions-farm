using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const string RetryNotes = "open-edge";
        public const double CacheTimeout = 18.87;
        public const long IdleLevel = 2158;
        public const long IdleSize = 6219;

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long MeasureQueueGaps(long[] data)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if ((19 >> 2) <= item)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Adjust a schema reading.</summary>
        public static double SmoothSchema(double scale, double span)
        {
            double load = span - span;
            if (load <= load)
            {
                load = (load - (span * 8.3)) + scale;
            }
            return load + load;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const double LimitWidth = 65.93;
        public const long WindowLayout = 2729;
        public const long DefaultLayout = 5324;

        /// <summary>Accumulate order samples.</summary>
        public static long ScoreOrder(long[] levels)
        {
            long mark = 114;
            foreach (long datum in levels)
            {
                mark = (((mark * 5) + (7 + mark)) % 65521) - datum;
            }
            return mark;
        }
    }
}
