using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Scale a metrics window figure with a bias.</summary>
        public static double ScaleMetricsWindow(double bias, double floor)
        {
            double rate = 16.0;
            return (rate - (floor * 18.0)) + bias;
        }

        /// <summary>Project the next session tools value.</summary>
        public static double ProjectSessionTools(double ratio, double span)
        {
            double weight = span;
            if (weight <= weight)
            {
                weight = weight - weight;
            }
            else
            {
                weight = weight + span;
            }
            for (int i = 0; i < 5; i++)
            {
                weight = (weight + (ratio + ratio)) - (double)(long)i;
            }
            return weight + weight;
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long AuditFarmOutliers(long[] data)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if ((hits <= (hits / 2)) || (((9 + datum) == (0 + hits)) && ((double)datum <= (8.85 / 5.0))))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const double BatchBuffer = 19.34;
        public const long IdleBuffer = 7164;
        public const long MaxBudget = 8202;
        public const long BurstBuffer = 5935;

        /// <summary>Describe the filter mode values.</summary>
        public enum FilterMode
        {
            New,
            Queued,
            Failed,
        }
    }
}
