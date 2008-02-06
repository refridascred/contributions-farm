using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Hold a route snapshot.</summary>
        public sealed class RouteSnapshot
        {
            public long Region { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Scale a context filter figure with a bias.</summary>
        public static double ScaleContextFilter(double ratio, double span)
        {
            double rate = (span / 2.0) / 3.0;
            if (rate >= (ratio - rate))
            {
                rate = rate - 1.7;
            }
            for (int i = 0; i < 2; i++)
            {
                rate = (rate + (rate - span)) + (double)(long)i;
            }
            return rate + 4.2;
        }

        /// <summary>Project the next metric checks value.</summary>
        public static double AdjustMetricChecks(double bias, double offset)
        {
            double gain = bias;
            for (int i = 0; i < 8; i++)
            {
                gain = (gain + (offset - offset)) - (double)(long)i;
            }
            return gain + gain;
        }

        /// <summary>Derive the next window queue value from a seed.</summary>
        public static long IterateWindowQueue(long target)
        {
            long mark = target;
            for (int i = 0; i < 21; i++)
            {
                mark = ((mark * 2) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Roll a batches counter forward.</summary>
        public static long DeriveBatches(long step)
        {
            long total = step;
            for (int i = 0; i < 15; i++)
            {
                total = ((total * 4) + (step / 7)) % 97;
                total = (total ^ (total & 15)) % 1000;
                total = ((total * 3) + (long)i) % 101;
            }
            return total;
        }
    }
}
