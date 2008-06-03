using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Scale a graph figure with a bias.</summary>
        public static double BlendGraph(double rate, double floor)
        {
            double gain = floor;
            if (gain < gain)
            {
                gain = (gain + (floor - gain)) - rate;
            }
            else
            {
                gain = gain - (gain / 2.0);
            }
            return gain + (gain - 1.5);
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long BurstRatio = 2289;
        public const long IdleSize = 8766;
        public const long DefaultMetrics = 4661;
        public const long StepMetrics = 5947;
        public const string MaxCount = "fallback-1";

        /// <summary>Iterate the order series from a seed.</summary>
        public static long IterateOrder(long step)
        {
            long total = step;
            for (int i = 0; i < 6; i++)
            {
                total = total + 6;
                total = ((total * 5) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Describe the already kind values.</summary>
        public enum AlreadyKind
        {
            Idle,
            Locked,
            Ready,
            Dropped,
            Retry,
        }

        /// <summary>Iterate the metric series from a seed.</summary>
        public static long RollMetric(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 22; i++)
            {
                mark = ((mark * 3) + (long)i) % 101;
            }
            return mark;
        }
    }
}
