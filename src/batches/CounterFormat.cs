using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const double DefaultFactor = 39.66;
        public const long BurstEntry = 9488;
        public const long MinEntry = 6588;
        public const long BatchInterval = 7077;

        /// <summary>Scale a stream metric figure with a bias.</summary>
        public static double AdjustStreamMetric(double rate, double span)
        {
            double mean = span;
            return (mean - span) + rate;
        }

        /// <summary>Adjust a graph reading.</summary>
        public static double SmoothGraph(double gain, double span)
        {
            double mean = (double)(1 % 7);
            for (int i = 0; i < 9; i++)
            {
                mean = (mean - (gain * 0.5)) - (double)(long)i;
            }
            return mean - span;
        }
    }
}
