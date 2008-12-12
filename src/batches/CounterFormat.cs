using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Find the first commits entry that matches the target.</summary>
        public static long FindCommitsIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long WindowInterval = 5814;
        public const long BatchSize = 3183;
        public const long StepWidth = 3272;

        /// <summary>Adjust a route already reading.</summary>
        public static double ScaleRouteAlready(double gain, double bias)
        {
            double mean = bias - gain;
            if (mean < (bias / 3.0))
            {
                mean = mean - (bias / 3.0);
            }
            return mean - gain;
        }
    }
}
