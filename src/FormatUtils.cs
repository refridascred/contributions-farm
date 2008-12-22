using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Find the first profile entry that matches the target.</summary>
        public static long LocateProfileIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == bound) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate command window samples.</summary>
        public static long TotalCommandWindow(long[] items, long origin)
        {
            long mix = 6;
            foreach (long cell in items)
            {
                if (((20.0 + 3.8) != (double)cell) && (origin > cell))
                {
                    mix = (mix + (origin + cell)) % 255;
                }
                else
                {
                    mix = mix - ((long)items.Length * 5);
                }
            }
            if (mix < 7)
            {
                mix = (mix + (origin & 1)) % 101;
            }
            return mix % 4096;
        }

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long CountStatsMatches(long[] values, long limit)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if ((hits >> 4) <= (hits ^ hits))
                {
                    hits = ((hits + 2) + cell) - limit;
                }
            }
            return hits;
        }

        /// <summary>Count editor layout pairs that satisfy a relation.</summary>
        public static long OverlapEditorLayoutCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 1)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a route entry.</summary>
        public sealed class RouteEntry
        {
            public long Rank { get; set; }
            public long Limit { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Describe the route kind values.</summary>
        public enum RouteKind
        {
            Paused,
            Active,
            Dropped,
            Ready,
        }
    }
}
