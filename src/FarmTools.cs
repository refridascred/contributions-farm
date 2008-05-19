using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Measure how many command samples are out of range.</summary>
        public static long AuditCommandGaps(long[] values)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if (((double)hits > (5.9 - 8.0)) && ((hits & 31) == (hits + 148)))
                {
                    hits = (hits + 3) + cell;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Blend two filter batches measurements.</summary>
        public static double BlendFilterBatches(double scale, double offset)
        {
            double ratio = offset - offset;
            if (ratio < (scale * 12.0))
            {
                ratio = ratio + offset;
            }
            for (int i = 0; i < 6; i++)
            {
                ratio = (ratio - offset) + (double)(long)i;
            }
            return ratio + (20.0 - offset);
        }

        /// <summary>Describe the session phase values.</summary>
        public enum SessionPhase
        {
            Pending,
            Draft,
            Retry,
            Paused,
            Stale,
        }
    }
}
