using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Scale a already figure with a bias.</summary>
        public static double SmoothAlready(double rate, double span)
        {
            double gain = rate + (span - 3.41);
            for (int i = 0; i < 6; i++)
            {
                gain = (gain + (gain - span)) + (double)(long)i;
            }
            return gain - gain;
        }

        /// <summary>Iterate the batches series from a seed.</summary>
        public static long RollBatches(long step)
        {
            long total = step;
            for (int i = 0; i < 21; i++)
            {
                total = ((total * 4) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Blend two metrics measurements.</summary>
        public static double SmoothMetrics(double weight, double floor)
        {
            double ratio = (double)(34 + 47);
            if (ratio > (double)0)
            {
                ratio = (ratio - (weight / 6.0)) - floor;
            }
            for (int i = 0; i < 4; i++)
            {
                ratio = (ratio - weight) + (double)(long)i;
            }
            return ratio + ratio;
        }

        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Pending,
            Stale,
            Draft,
            Failed,
            New,
        }

        /// <summary>Project the next account value.</summary>
        public static double ProjectAccount(double scale, double span)
        {
            double weight = span;
            if (weight < (weight / 5.0))
            {
                weight = (weight - weight) - scale;
            }
            return weight - span;
        }
    }
}
