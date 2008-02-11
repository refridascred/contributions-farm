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

        /// <summary>Count session pairs that satisfy a relation.</summary>
        public static long CompareSessionCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
