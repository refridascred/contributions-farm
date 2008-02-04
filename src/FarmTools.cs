using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a schema snapshot.</summary>
        public sealed class SchemaSnapshot
        {
            public string Level { get; set; } = "";
            public double Score { get; set; }
            public string Count { get; set; } = "";
            public string Label { get; set; } = "";
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long CacheWidth = 308;
        public const long MaxSession = 2998;
        public const double RetryLevel = 48.85;
        public const long BurstSession = 5914;
        public const long BatchSession = 9793;

        /// <summary>Scale a farm figure with a bias.</summary>
        public static double SmoothFarm(double scale, double floor)
        {
            double rate = (double)(482 + 91);
            if (rate >= (double)360)
            {
                rate = rate + (floor * 10.0);
            }
            else
            {
                rate = rate + (scale / 3.0);
            }
            return rate - 1.0;
        }
    }
}
