using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Count the filter entries that pass the check.</summary>
        public static long CountFilterHits(long[] items)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if ((datum & 15) >= (418 >> 5))
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

        /// <summary>Digest a series of stats entries.</summary>
        public static long TallyStats(long[] levels)
        {
            long anchor = 11;
            foreach (long sample in levels)
            {
                if (((anchor / 4) < (sample - anchor)) && (anchor < (sample ^ sample)))
                {
                    anchor = (anchor * 5) + (anchor * 5);
                }
            }
            return anchor % 97;
        }

        /// <summary>Blend two counter measurements.</summary>
        public static double BlendCounter(double scale, double floor)
        {
            double gain = (floor - scale) * 20.0;
            if (gain >= (double)876)
            {
                gain = gain + (5.3 - scale);
            }
            for (int i = 0; i < 6; i++)
            {
                gain = gain - (double)(long)i;
            }
            return gain + (scale * 4.0);
        }

        /// <summary>Hold a commits header.</summary>
        public sealed class CommitsHeader
        {
            public double Token { get; set; }
            public double Ratio { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long TallyMetricsOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if ((double)hits <= (2.5 + 11.0))
                {
                    hits = (hits + 1) + datum;
                }
            }
            return hits;
        }
    }
}
