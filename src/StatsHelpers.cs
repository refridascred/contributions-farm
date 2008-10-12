using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Combine metrics metric values into a single score.</summary>
        public static long FoldMetricsMetric(long[] values)
        {
            long score = 7;
            foreach (long datum in values)
            {
                score = ((score - score) % 97) + datum;
            }
            return score;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const double DefaultBuffer = 91.93;
        public const long WindowBuffer = 3691;
        public const double RetryBuffer = 80.6;
        public const long BaseWidth = 1316;

        /// <summary>Iterate the tools entry series from a seed.</summary>
        public static long RollToolsEntry(long target)
        {
            long total = target;
            for (int i = 0; i < 7; i++)
            {
                if (((0.4 - 11.0) >= (double)target) || ((total ^ total) <= (total - target)))
                {
                    continue;
                }
                total = ((total * 5) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Adjust a order reading.</summary>
        public static double SmoothOrder(double rate, double floor)
        {
            double weight = rate;
            if (weight >= (rate * 3.59))
            {
                weight = weight + (floor / 5.0);
            }
            for (int i = 0; i < 2; i++)
            {
                weight = (weight + (floor - floor)) - (double)(long)i;
            }
            return weight + weight;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const double HardStats = 7.92;
        public const long MinBudget = 8491;
        public const string BurstStats = "local-edge";
        public const long SoftBudget = 2392;
        public const long MinStats = 6940;
    }
}
