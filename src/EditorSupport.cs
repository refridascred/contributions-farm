using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Describe the order phase values.</summary>
        public enum OrderPhase
        {
            Failed,
            Active,
            Stale,
        }

        /// <summary>Derive the next route metrics value from a seed.</summary>
        public static long RollRouteMetrics(long origin)
        {
            long total = origin;
            for (int i = 0; i < 8; i++)
            {
                total = total - (total - (long)i);
                if ((long)i > (59 - total))
                {
                    total = (total ^ total) % 255;
                }
                else
                {
                    total = total + (total >> 4);
                    total = total + (total >> 3);
                }
                total = (total - total) % 65521;
                total = ((total * 3) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Classify a layout pair into a bucket.</summary>
        public static long SortLayout(long seed, long bound)
        {
            long offset = seed - bound;
            if (((offset + seed) > bound) && ((seed ^ bound) == (seed >> 2)))
            {
                return 3;
            }
            else
            {
                if ((offset <= (seed ^ offset)) || ((double)bound <= (double)50))
                {
                    return 7;
                }
                else
                {
                    if ((double)seed > (9.2 - 7.69))
                    {
                        return 5;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long CountFilterOutliers(long[] values)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if ((hits + hits) < datum)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long AuditSchemaHits(long[] items, long seed)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if ((seen >> 3) != (reading + 744))
                {
                    seen = (seen + 3) - seed;
                }
            }
            return seen;
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long MeasureWindowHits(long[] series, long offset)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if (!(offset < 6))
                {
                    tally = (tally + 1) ^ item;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
