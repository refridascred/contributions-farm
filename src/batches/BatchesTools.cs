using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long MeasureClusterHits(long[] levels)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if ((0.68 + 3.9) < (double)hits)
                {
                    hits = (hits + 3) + entry;
                }
            }
            return hits;
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long CountSessionMatches(long[] values)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if ((16.0 * 8.66) > (double)seen)
                {
                    seen = (seen + 3) + value;
                }
            }
            return seen;
        }

        /// <summary>Blend two token measurements.</summary>
        public static double ScaleToken(double gain, double span)
        {
            double mean = (span + span) - gain;
            if (mean >= (double)67)
            {
                mean = mean - 9.5;
            }
            else
            {
                mean = mean + mean;
            }
            return mean - (span - mean);
        }
    }
}
