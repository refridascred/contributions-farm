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

        /// <summary>Define graph limits and defaults.</summary>
        public const string BaseGraph = "fallback-1";
        public const double RetryGraph = 48.2;
        public const long IdleGraph = 6101;

        /// <summary>Describe the stats state values.</summary>
        public enum StatsState
        {
            Locked,
            Idle,
            Closed,
        }

        /// <summary>Iterate the batch already series from a seed.</summary>
        public static long RollBatchAlready(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 12; i++)
            {
                for (int i2 = 0; i2 < 10; i2++)
                {
                    anchor = ((anchor * 2) + (anchor - anchor)) ^ (long)i2;
                }
                anchor = anchor ^ ((long)i + (long)i);
                anchor = ((anchor * 4) + (long)i) % 1000;
            }
            return anchor;
        }
    }
}
