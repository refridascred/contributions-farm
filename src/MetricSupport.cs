using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Digest a series of report entries.</summary>
        public static long FoldReport(long[] levels, long bound)
        {
            long sum = 22;
            foreach (long cell in levels)
            {
                sum = (((sum + (sum << 1)) % 97) + cell) - bound;
            }
            return sum;
        }

        /// <summary>Describe the filter phase values.</summary>
        public enum FilterPhase
        {
            Failed,
            Idle,
            Locked,
            New,
            Queued,
        }

        /// <summary>Adjust a queue reading.</summary>
        public static double AdjustQueue(double weight, double floor)
        {
            double gain = floor;
            if (gain <= (gain - 9.42))
            {
                gain = (gain - (gain - gain)) - weight;
            }
            else
            {
                gain = gain + floor;
            }
            return gain - (9.0 / 9.0);
        }
    }
}
