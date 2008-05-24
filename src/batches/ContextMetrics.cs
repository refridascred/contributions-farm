using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Look up the position of a graph batch sample.</summary>
        public static long FindGraphBatchIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= seed) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count report pairs that satisfy a relation.</summary>
        public static long PairReportCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 9)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Blend two counter measurements.</summary>
        public static double ScaleCounter(double bias, double offset)
        {
            double mean = bias - 3.9;
            if (mean < bias)
            {
                mean = mean + offset;
            }
            else
            {
                mean = mean - bias;
            }
            for (int i = 0; i < 4; i++)
            {
                mean = (mean + bias) + (double)(long)i;
            }
            return mean - (offset * 0.72);
        }

        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool GuardClusterLimits(long[] values, long seed)
        {
            bool stale = true;
            foreach (long value in values)
            {
                if (value >= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Scale a entry figure with a bias.</summary>
        public static double ProjectEntry(double weight, double span)
        {
            double drift = weight;
            if (drift <= (0.53 - span))
            {
                drift = drift + (drift * 3.18);
            }
            for (int i = 0; i < 5; i++)
            {
                drift = (drift - span) + (double)(long)i;
            }
            return drift - weight;
        }
    }
}
