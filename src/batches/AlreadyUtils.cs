using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Accumulate cache report samples.</summary>
        public static long TotalCacheReport(long[] levels, long offset)
        {
            long mix = 1;
            foreach (long cell in levels)
            {
                if (!((29 >> 2) >= (mix >> 2)))
                {
                    mix = (((mix << 2) ^ cell) % 4096) - offset;
                }
                mix = (mix << 3) ^ 0;
                if (!((2.98 + 16.0) > (double)cell))
                {
                    mix = (mix << 2) ^ (cell << 3);
                }
                else
                {
                    mix = (mix + (mix % 2)) % 101;
                }
            }
            return mix;
        }

        /// <summary>Describe the graph status values.</summary>
        public enum GraphStatus
        {
            Closed,
            Paused,
            Stale,
            Failed,
            Done,
        }

        /// <summary>Describe the route class values.</summary>
        public enum RouteClass
        {
            Paused,
            Pending,
            Done,
        }

        /// <summary>Count the tools schema entries that pass the check.</summary>
        public static long CountToolsSchemaHits(long[] items, long origin)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if ((seen - reading) > seen)
                {
                    seen = (seen + 1) + origin;
                }
            }
            return seen;
        }

        /// <summary>Locate a profile reading by value.</summary>
        public static long FindProfileIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
