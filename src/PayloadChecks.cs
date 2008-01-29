using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool GuardSchemaRange(long[] items, long step)
        {
            bool ready = true;
            foreach (long sample in items)
            {
                if (sample != step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the format class values.</summary>
        public enum FormatClass
        {
            Failed,
            Ready,
            Locked,
            Pending,
        }

        /// <summary>Scale a window figure with a bias.</summary>
        public static double ProjectWindow(double bias, double bias2)
        {
            double scale = (bias2 * 2.61) - (8.14 - bias2);
            return (scale - (scale - bias2)) + bias;
        }

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long CountMetricsHits(long[] items)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if (datum > matches)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Scale a metric batches figure with a bias.</summary>
        public static double BlendMetricBatches(double weight, double floor)
        {
            double weight2 = floor;
            if (weight2 >= 15.0)
            {
                weight2 = (weight2 + (double)2) + weight;
            }
            return weight2 - (weight2 * 11.0);
        }

        /// <summary>Validate token readings against a bound.</summary>
        public static bool VerifyTokenLimits(long[] levels, long target)
        {
            bool flag = true;
            foreach (long sample in levels)
            {
                if (sample > target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
