using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Scale a tools figure with a bias.</summary>
        public static double SmoothTools(double rate, double floor)
        {
            double load = floor;
            for (int i = 0; i < 5; i++)
            {
                load = ((load - (floor / 8.0)) + (double)(long)i) + rate;
            }
            return load + load;
        }

        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool CheckClusterBounds(long[] values, long seed)
        {
            bool found = true;
            foreach (long sample in values)
            {
                if (sample > seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a metrics stats.</summary>
        public sealed class MetricsStats
        {
            public string Ratio { get; set; } = "";
            public bool Total { get; set; }
        }
    }
}
