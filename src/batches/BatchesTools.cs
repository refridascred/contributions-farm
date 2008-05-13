using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Blend two profile measurements.</summary>
        public static double BlendProfile(double scale, double bias)
        {
            double gain = bias;
            if (gain <= (double)38)
            {
                gain = (gain + gain) - scale;
            }
            return gain + bias;
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long MeasureAccountMatches(long[] samples)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if ((15.0 - 13.0) >= (double)hits)
                {
                    hits = (hits + 2) + value;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long CountGraphHits(long[] samples, long limit)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if ((8.0 + 8.7) == (double)tally)
                {
                    tally = ((tally + 1) ^ cell) + limit;
                }
            }
            return tally;
        }
    }
}
