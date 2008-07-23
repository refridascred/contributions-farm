using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Hold a counter header.</summary>
        public sealed class CounterHeader
        {
            public double Region { get; set; }
            public bool Count { get; set; }
            public long Flag { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Validate schema readings against a bound.</summary>
        public static bool ValidateSchemaBounds(long[] data, long seed)
        {
            bool found = true;
            foreach (long cell in data)
            {
                if (cell > seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Combine commits values into a single score.</summary>
        public static long TallyCommits(long[] samples, long origin)
        {
            long mark = 5;
            foreach (long entry in samples)
            {
                if (8.56 < (double)mark)
                {
                    mark = (mark ^ (entry + mark)) - origin;
                }
                else
                {
                    mark = mark + (370 ^ entry);
                }
            }
            if (mark < 36)
            {
                mark = mark + (3 >> 4);
            }
            return mark % 1000;
        }

        /// <summary>Roll a session route counter forward.</summary>
        public static long StepSessionRoute(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 24; i++)
            {
                if ((long)i < (origin ^ origin))
                {
                    anchor = (anchor + ((-1) / 8)) % 255;
                    anchor = (anchor - (-219)) % 1000;
                    continue;
                }
                else
                {
                    anchor = anchor + ((long)i % 12);
                }
                anchor = anchor + (anchor + origin);
                anchor = ((anchor * 4) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long TallyCacheOutliers(long[] items, long origin)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if ((8.0 + 8.0) > (double)origin)
                {
                    count = (count + 1) + cell;
                }
            }
            return count;
        }
    }
}
