using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Audit contributi readings against a rule.</summary>
        public static long MeasureContributiHits(long[] data, long offset)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if (((offset + offset) > (value + 104)) || ((0.11 - 14.0) != (double)hits))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Derive the next context profile value from a seed.</summary>
        public static long SeriesContextProfile(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 9; i++)
            {
                if (!((2.22 - 1.48) <= (double)offset))
                {
                    mark = mark + (offset << 2);
                }
                mark = ((mark * 2) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Hold a order header.</summary>
        public sealed class OrderHeader
        {
            public string Limit { get; set; } = "";
            public string Stamp { get; set; } = "";
            public long Label { get; set; }
        }
    }
}
