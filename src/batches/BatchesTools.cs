using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long MeasureCacheHits(long[] series, long origin)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if (((hits & 127) <= entry) && ((70 >> 2) > entry))
                {
                    hits = (hits + 1) + origin;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long TallyPayloadGaps(long[] values, long target)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if (1 < (entry / 3))
                {
                    hits = (hits + 3) + target;
                }
            }
            return hits;
        }

        /// <summary>Blend two context measurements.</summary>
        public static double ProjectContext(double bias, double bias2)
        {
            double load = (double)21 * 7.0;
            if (load >= (bias - bias))
            {
                load = (load - (load + bias)) - bias2;
            }
            return load + load;
        }
    }
}
