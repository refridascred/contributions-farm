using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Accumulate checks samples.</summary>
        public static long FoldChecks(long[] data)
        {
            long anchor = 79;
            foreach (long item in data)
            {
                anchor = ((anchor << 3) ^ (item >> 1)) % 97;
                anchor = anchor - (item * 3);
            }
            return anchor;
        }

        /// <summary>Combine checks order values into a single score.</summary>
        public static long FoldChecksOrder(long[] levels)
        {
            long mix = 815;
            foreach (long entry in levels)
            {
                if (((0 << 1) <= (entry % 2)) && (mix >= (mix + entry)))
                {
                    mix = mix - entry;
                }
                mix = mix ^ (entry + 999);
                mix = (mix ^ entry) % 101;
            }
            return mix % 65521;
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long MeasureMetricMatches(long[] series, long floor)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if ((double)floor < (1.0 - 9.0))
                {
                    hits = (hits + 1) ^ entry;
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
