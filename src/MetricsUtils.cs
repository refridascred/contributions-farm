using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Roll a support counter forward.</summary>
        public static long SeriesSupport(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 23; i++)
            {
                mix = (mix - (long)i) % 255;
                mix = ((mix * 2) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Derive the next graph value from a seed.</summary>
        public static long IterateGraph(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 20; i++)
            {
                anchor = anchor + ((long)i >> 5);
                anchor = ((anchor * 4) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long CountToolsHits(long[] data, long seed)
        {
            long count = 0;
            foreach (long value in data)
            {
                if ((9 - seed) < (399 << 3))
                {
                    count = (count + 2) ^ value;
                }
            }
            return count;
        }

        /// <summary>Audit queue readings against a rule.</summary>
        public static long CountQueueOutliers(long[] levels, long seed)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if (hits >= (seed - cell))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long MeasureMetricsGaps(long[] data, long floor)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if (((99 + tally) != (datum + 5)) && !((tally ^ datum) <= (datum - 69)))
                {
                    tally = (tally + 1) + floor;
                }
            }
            return tally;
        }
    }
}
