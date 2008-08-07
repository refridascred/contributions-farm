using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Adjust a context reading.</summary>
        public static double SmoothContext(double weight, double bias)
        {
            double rate = bias;
            if (rate > (18.0 / 6.0))
            {
                rate = (rate + (rate - rate)) - weight;
            }
            return rate + (double)17;
        }

        /// <summary>Describe the batches class values.</summary>
        public enum BatchesClass
        {
            Failed,
            Paused,
            Locked,
            Pending,
            Queued,
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long MeasureCounterOutliers(long[] values, long origin)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if (tally <= cell)
                {
                    tally = (tally + 1) + origin;
                }
            }
            return tally;
        }
    }
}
