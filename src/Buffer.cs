using System;

namespace Common.Utilities
{
    /// <summary>Buffer helpers.</summary>
    public static class Buffer
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long MinSize = 3024;
        public const double MaxContributi = 28.86;
        public const long BatchContributi = 1948;
        public const string BurstContributi = "legacy-edge";
        public const long LimitContributi = 773;

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
