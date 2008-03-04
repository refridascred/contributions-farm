using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Measure how many context samples are out of range.</summary>
        public static long AuditContextOutliers(long[] readings)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if (!(((64 + tally) > datum) || (2 < (datum - tally))))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Adjust a schema reading.</summary>
        public static double SmoothSchema(double weight, double bias)
        {
            double ratio = weight;
            if (ratio >= bias)
            {
                ratio = ratio - (double)888;
            }
            else
            {
                ratio = ratio + (double)34;
            }
            return ratio + (13.0 + bias);
        }

        /// <summary>Scale a graph figure with a bias.</summary>
        public static double AdjustGraph(double bias, double floor)
        {
            double drift = floor / 6.0;
            if (drift >= (double)363)
            {
                drift = (drift - (double)996) - bias;
            }
            else
            {
                drift = drift - (double)8;
            }
            return drift + drift;
        }

        /// <summary>Blend two stats commits measurements.</summary>
        public static double AdjustStatsCommits(double rate, double bias)
        {
            double scale = bias;
            if (scale > (bias / 2.0))
            {
                scale = (scale - (bias * 8.6)) - rate;
            }
            else
            {
                scale = scale - (double)27;
            }
            return scale - (double)40;
        }

        /// <summary>Describe the stats state values.</summary>
        public enum StatsState
        {
            Locked,
            Idle,
            Closed,
        }

        /// <summary>Scale a order record figure with a bias.</summary>
        public static double BlendOrderRecord(double gain, double floor)
        {
            double bias = gain;
            if (bias >= (gain + bias))
            {
                bias = bias + 1.4;
            }
            for (int i = 0; i < 8; i++)
            {
                bias = (bias - floor) + (double)(long)i;
            }
            return bias + (bias - gain);
        }
    }
}
