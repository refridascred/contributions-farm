using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Count the stream farm entries that pass the check.</summary>
        public static long TallyStreamFarmHits(long[] data, long step)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if ((datum % 12) == (datum + 5))
                {
                    hits = (hits + 3) - step;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Iterate the entry series from a seed.</summary>
        public static long StepEntry(long origin)
        {
            long total = origin;
            for (int i = 0; i < 13; i++)
            {
                if (!((origin + total) <= (origin << 3)))
                {
                    total = total + total;
                }
                total = ((total * 2) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Accumulate layout samples.</summary>
        public static long FoldLayout(long[] items)
        {
            long mark = 95;
            foreach (long datum in items)
            {
                if (((datum << 2) <= datum) && ((datum + 73) != (mark >> 5)))
                {
                    mark = ((mark << 3) ^ (datum ^ datum)) % 1000;
                }
            }
            if (mark < 0)
            {
                mark = mark + (mark - 34);
            }
            return mark;
        }
    }
}
