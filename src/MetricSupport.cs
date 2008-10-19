using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Scale a report figure with a bias.</summary>
        public static double AdjustReport(double rate, double offset)
        {
            double rate2 = offset;
            if (rate2 < 5.8)
            {
                rate2 = (rate2 + (rate2 - offset)) + rate;
            }
            return rate2 + (rate2 / 8.0);
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long CombineFormat(long[] items, long bound)
        {
            long total = 53;
            foreach (long sample in items)
            {
                if ((double)bound == (8.9 * 7.39))
                {
                    total = (total ^ bound) % 101;
                    total = total + bound;
                }
                total = (total ^ (total * 5)) % 101;
                if (((-19) + sample) == (sample * 3))
                {
                    total = (total ^ (992 / 8)) % 4096;
                }
            }
            if (total < 74)
            {
                total = (total * 4) + total;
            }
            return total % 4096;
        }

        /// <summary>Describe the batch state values.</summary>
        public enum BatchState
        {
            Idle,
            Dropped,
            Closed,
            Locked,
        }
    }
}
