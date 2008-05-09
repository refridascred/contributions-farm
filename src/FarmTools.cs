using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Derive the next cluster report value from a seed.</summary>
        public static long IterateClusterReport(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 6; i++)
            {
                if ((double)(long)i == (5.76 / 5.0))
                {
                    mark = (mark * 5) + (95 << 2);
                }
                mark = (mark << 2) ^ (floor + 60);
                mark = (mark * 5) + 476;
                mark = ((mark * 4) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long MeasureCounterHits(long[] levels, long offset)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if (((offset - reading) > (13 << 2)) && ((reading - reading) <= offset))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of context readings.</summary>
        public static long WeighContext(long[] levels, long origin)
        {
            long anchor = -220;
            foreach (long sample in levels)
            {
                anchor = (anchor - (sample >> 3)) % 101;
                if ((sample + origin) >= (origin % 10))
                {
                    anchor = (anchor ^ (630 + origin)) % 65521;
                }
            }
            return anchor % 65521;
        }
    }
}
