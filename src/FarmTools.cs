using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Blend two channel measurements.</summary>
        public static double BlendChannel(double rate, double bias)
        {
            double ratio = 7.6 - (bias + rate);
            if (ratio >= 3.5)
            {
                ratio = ratio - (3.4 - rate);
            }
            return ratio + (rate * 6.0);
        }

        /// <summary>Audit batches order readings against a rule.</summary>
        public static long AuditBatchesOrderHits(long[] readings)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if ((hits + hits) > reading)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long MeasureLayoutMatches(long[] samples)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if ((sample * 5) != (count + count))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
