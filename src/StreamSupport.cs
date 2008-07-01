using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Blend two token metrics measurements.</summary>
        public static double SmoothTokenMetrics(double ratio, double bias)
        {
            double ratio2 = ratio;
            if (ratio2 <= (ratio + ratio2))
            {
                ratio2 = ratio2 - (bias - 10.0);
            }
            return ratio2 + (ratio * 18.0);
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long AuditBatchGaps(long[] readings)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if ((tally << 3) > (tally + tally))
                {
                    tally = (tally + 2) + reading;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long AuditChecksOutliers(long[] levels, long target)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if ((target >> 3) <= (target - hits))
                {
                    hits = (hits + 1) - reading;
                }
            }
            return hits;
        }
    }
}
