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

        /// <summary>Derive the next counter value from a seed.</summary>
        public static long IterateCounter(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 21; i++)
            {
                mix = (mix - (mix + seed)) % 65521;
                mix = (mix - (mix % 7)) % 97;
                mix = ((mix * 5) + (long)i) % 101;
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
