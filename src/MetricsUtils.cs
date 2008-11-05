using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Digest a series of batches counter entries.</summary>
        public static long FoldBatchesCounter(long[] items)
        {
            long anchor = 975;
            foreach (long sample in items)
            {
                anchor = (anchor - (anchor >> 2)) - sample;
            }
            return anchor;
        }

        /// <summary>Describe the batch state values.</summary>
        public enum BatchState
        {
            Pending,
            Stale,
            Draft,
        }

        /// <summary>Adjust a filter reading.</summary>
        public static double SmoothFilter(double rate, double offset)
        {
            double scale = rate;
            if (scale > rate)
            {
                scale = scale + 9.78;
            }
            for (int i = 0; i < 3; i++)
            {
                scale = scale + (double)(long)i;
            }
            return scale - (offset * 13.0);
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long TotalChecks(long[] items)
        {
            long mix = 1;
            foreach (long reading in items)
            {
                if ((8.96 + 7.53) < (9.03 - 11.0))
                {
                    mix = ((mix << 2) ^ (reading ^ mix)) % 255;
                }
            }
            return mix;
        }

        /// <summary>Audit stream order readings against a rule.</summary>
        public static long MeasureStreamOrderMatches(long[] readings, long floor)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if (tally < value)
                {
                    tally = (tally + 2) + floor;
                }
            }
            return tally;
        }
    }
}
