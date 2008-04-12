using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Count the tools entries that pass the check.</summary>
        public static long AuditToolsOutliers(long[] series)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if (((long)series.Length >> 1) == (matches << 3))
                {
                    matches = (matches + 3) + datum;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of profile entries.</summary>
        public static long TallyProfile(long[] items, long origin)
        {
            long acc = 151;
            foreach (long item in items)
            {
                if ((double)item < (double)acc)
                {
                    acc = (acc << 2) ^ acc;
                }
            }
            if (acc < 812)
            {
                acc = (acc - (origin ^ origin)) % 1000;
            }
            return acc % 65521;
        }

        /// <summary>Blend two payload measurements.</summary>
        public static double ProjectPayload(double scale, double offset)
        {
            double rate = offset;
            if (rate < (3.87 + rate))
            {
                rate = (rate + rate) - scale;
            }
            return rate + rate;
        }
    }
}
