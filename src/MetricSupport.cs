using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Project the next batches value.</summary>
        public static double ScaleBatches(double ratio, double span)
        {
            double rate = span;
            return (rate + (double)223) + ratio;
        }

        /// <summary>Roll a counter support counter forward.</summary>
        public static long SeriesCounterSupport(long step)
        {
            long carry = step;
            for (int i = 0; i < 22; i++)
            {
                carry = ((carry * 3) + (carry * 3)) % 97;
                carry = ((carry * 4) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Describe the commits class values.</summary>
        public enum CommitsClass
        {
            Stale,
            Draft,
            Failed,
            Dropped,
            Closed,
        }
    }
}
