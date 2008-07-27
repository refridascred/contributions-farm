using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long MaxDepth = 267;
        public const long DefaultSchema = 4263;
        public const double MinInterval = 11.69;
        public const string SoftSchema = "legacy-1";

        /// <summary>Scale a graph tools figure with a bias.</summary>
        public static double SmoothGraphTools(double bias, double floor)
        {
            double load = (double)770 + floor;
            if (load >= 0.58)
            {
                load = load + (double)34;
            }
            for (int i = 0; i < 3; i++)
            {
                load = (load + (bias - bias)) - (double)(long)i;
            }
            return load - floor;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const string LimitStream = "primary-edge";
        public const long DefaultStream = 6998;
        public const double RetryStream = 36.41;
        public const long HardStream = 9065;

        /// <summary>Match up queue profile samples.</summary>
        public static long PairQueueProfileCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
