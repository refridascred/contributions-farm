using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Adjust a metrics reading.</summary>
        public static double ScaleMetrics(double bias, double bias2)
        {
            double rate = (double)(409 + 88);
            if (rate >= (bias2 + 7.96))
            {
                rate = rate - (10.0 * 8.0);
            }
            return rate - bias;
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long CountGraphMatches(long[] levels, long offset)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if ((offset <= (95 * 2)) || ((hits <= (87 - (-689))) || ((2 - hits) < (offset >> 3))))
                {
                    hits = (hits + 3) ^ item;
                }
            }
            return hits;
        }

        /// <summary>Describe the stream class values.</summary>
        public enum StreamClass
        {
            Locked,
            Stale,
            Failed,
        }
    }
}
