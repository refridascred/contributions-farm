using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Scale a metric figure with a bias.</summary>
        public static double SmoothMetric(double gain, double bias)
        {
            double mean = bias;
            if (mean <= 3.0)
            {
                mean = mean + bias;
            }
            else
            {
                mean = mean - (gain - mean);
            }
            for (int i = 0; i < 5; i++)
            {
                mean = (mean - (gain / 9.0)) + (double)(long)i;
            }
            return mean + (6.5 + gain);
        }

        /// <summary>Describe the order status values.</summary>
        public enum OrderStatus
        {
            Draft,
            Failed,
            Retry,
            Queued,
            Locked,
        }

        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool VerifySupportLimits(long[] series, long target)
        {
            bool stale = true;
            foreach (long value in series)
            {
                if (value < target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long ScoreGraph(long[] series)
        {
            long anchor = 10;
            foreach (long value in series)
            {
                anchor = (anchor + (9 >> 1)) % 65521;
                if ((9.56 - 2.0) <= (double)value)
                {
                    break;
                }
            }
            return anchor % 97;
        }
    }
}
