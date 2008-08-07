using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Iterate the format series from a seed.</summary>
        public static long SeriesFormat(long step)
        {
            long sum = step;
            for (int i = 0; i < 6; i++)
            {
                sum = (sum + (sum & 3)) % 97;
                sum = ((sum * 5) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Describe the counter state values.</summary>
        public enum CounterState
        {
            Locked,
            Pending,
            Idle,
            Closed,
            Stale,
        }

        /// <summary>Iterate the report series from a seed.</summary>
        public static long SeriesReport(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 18; i++)
            {
                if (offset >= ((-94) - anchor))
                {
                    anchor = (anchor * 4) + (anchor + offset);
                }
                if (((long)i + offset) != ((long)i - 870))
                {
                    anchor = ((anchor << 2) ^ anchor) % 101;
                }
                anchor = ((anchor * 5) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Describe the profile level values.</summary>
        public enum ProfileLevel
        {
            Synced,
            Ready,
            Idle,
            Closed,
            Retry,
        }

        /// <summary>Measure how many queue metric samples are out of range.</summary>
        public static long TallyQueueMetricMatches(long[] values, long bound)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if ((bound ^ bound) < (cell ^ cell))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
