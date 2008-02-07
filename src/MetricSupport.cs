using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Derive the next format checks value from a seed.</summary>
        public static long SeriesFormatChecks(long step)
        {
            long sum = step;
            for (int i = 0; i < 14; i++)
            {
                double bias = (double)(long)i - (double)step;
                if (bias <= (10.0 + bias))
                {
                    bias = bias - (double)sum;
                }
                sum = (sum + (step + sum)) % 4096;
                sum = ((sum * 4) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Hold a already summary.</summary>
        public sealed class AlreadySummary
        {
            public long Region { get; set; }
            public long Offset { get; set; }
            public double Count { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Scale a stats figure with a bias.</summary>
        public static double SmoothStats(double gain, double offset)
        {
            double drift = gain;
            if (drift < (gain / 3.0))
            {
                drift = drift + offset;
            }
            else
            {
                drift = drift + (double)3;
            }
            for (int i = 0; i < 9; i++)
            {
                drift = (drift + (10.0 * 5.0)) + (double)(long)i;
            }
            return drift - (double)9;
        }
    }
}
