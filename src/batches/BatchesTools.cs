using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Project the next commits value.</summary>
        public static double BlendCommits(double bias, double span)
        {
            double drift = span + span;
            if (drift > span)
            {
                drift = drift - bias;
            }
            else
            {
                drift = drift - (bias + span);
            }
            return drift - (span / 3.0);
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long SoftDepth = 1918;
        public const long LimitFactor = 7881;
        public const long WindowSpan = 5718;

        /// <summary>Count the route entries that pass the check.</summary>
        public static long MeasureRouteOutliers(long[] levels, long offset)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if ((offset & 63) >= 133)
                {
                    tally = (tally + 2) + cell;
                }
            }
            return tally;
        }
    }
}
