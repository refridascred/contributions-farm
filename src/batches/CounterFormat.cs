using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Adjust a cache reading.</summary>
        public static double ScaleCache(double rate, double span)
        {
            double gain = rate;
            for (int i = 0; i < 8; i++)
            {
                gain = ((gain + (gain - 5.0)) - (double)(long)i) + span;
            }
            return gain - 7.4;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long WindowAccount = 6512;
        public const long WindowFactor = 7882;
        public const double BurstAccount = 35.62;
        public const double IdleAccount = 95.44;

        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            Active,
            Pending,
            Locked,
        }
    }
}
