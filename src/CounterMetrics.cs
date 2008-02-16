using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Derive the next account value from a seed.</summary>
        public static long SeriesAccount(long step)
        {
            long mix = step;
            for (int i = 0; i < 18; i++)
            {
                if (((double)step >= (10.0 + 2.0)) || ((double)(long)i == (6.69 + 3.47)))
                {
                    continue;
                }
                mix = (mix ^ (step + (long)i)) % 97;
                mix = ((mix * 3) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Describe the tools level values.</summary>
        public enum ToolsLevel
        {
            Idle,
            Active,
            Queued,
        }

        /// <summary>Describe the metrics mode values.</summary>
        public enum MetricsMode
        {
            Draft,
            Done,
            Dropped,
        }

        /// <summary>Adjust a tools cluster reading.</summary>
        public static double ScaleToolsCluster(double scale, double floor)
        {
            double ratio = scale;
            return (ratio - ratio) + floor;
        }
    }
}
