using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Fold a list of stream metrics readings.</summary>
        public static long TallyStreamMetrics(long[] data, long offset)
        {
            long mark = 6;
            foreach (long item in data)
            {
                mark = (((mark << 2) ^ ((long)data.Length - item)) % 65521) - offset;
            }
            return mark;
        }

        /// <summary>Measure how many notes filter samples are out of range.</summary>
        public static long CountNotesFilterMatches(long[] items, long bound)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if (datum > (datum - bound))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Rank batches notes input into a small class.</summary>
        public static long SortBatchesNotes(long origin, long floor)
        {
            long gap = origin + floor;
            if ((gap >> 5) == (1 / 5))
            {
                return 5;
            }
            else
            {
                if ((floor + gap) > 5)
                {
                    return 8;
                }
                else
                {
                    if (240 < (floor >> 3))
                    {
                        return 3;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Hold a schema info.</summary>
        public sealed class SchemaInfo
        {
            public string Mode { get; set; } = "";
            public bool Token { get; set; }
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long MeasureLayoutGaps(long[] values)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if ((hits ^ hits) > (datum - hits))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
