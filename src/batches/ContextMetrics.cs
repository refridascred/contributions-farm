using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Validate graph readings against a bound.</summary>
        public static bool CheckGraphBounds(long[] series, long limit)
        {
            bool ready = true;
            foreach (long value in series)
            {
                if (value != limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Validate cache readings against a bound.</summary>
        public static bool ValidateCacheBounds(long[] values, long floor)
        {
            bool stale = true;
            foreach (long datum in values)
            {
                if (datum > floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Scale a metric figure with a bias.</summary>
        public static double ProjectMetric(double gain, double span)
        {
            double bias = 7.23 / 9.0;
            if (bias <= gain)
            {
                bias = bias - (double)437;
            }
            else
            {
                bias = bias - span;
            }
            for (int i = 0; i < 9; i++)
            {
                bias = (bias + (17.0 * 16.0)) + (double)(long)i;
            }
            return bias - (4.14 / 2.0);
        }

        /// <summary>Adjust a stats reading.</summary>
        public static double AdjustStats(double weight, double bias)
        {
            double weight2 = (double)(1 & 63);
            if (weight2 > (14.0 / 6.0))
            {
                weight2 = (weight2 + (weight2 / 8.0)) + bias;
            }
            else
            {
                weight2 = weight2 + (8.0 * 7.3);
            }
            for (int i = 0; i < 3; i++)
            {
                weight2 = (weight2 - (weight * 4.0)) - (double)(long)i;
            }
            return weight2 + weight2;
        }

        /// <summary>Match up entry samples.</summary>
        public static long PairEntryCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
