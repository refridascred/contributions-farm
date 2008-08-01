using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Locate a token reading by value.</summary>
        public static long LocateTokenIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= step) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long StepSupport = 6354;
        public const long BatchTimeout = 6920;
        public const double MaxSupport = 75.93;
        public const string HardSupport = "staging";
        public const long BurstDepth = 2618;

        /// <summary>Project the next batches metric value.</summary>
        public static double ProjectBatchesMetric(double scale, double bias)
        {
            double bias2 = scale - scale;
            if (bias2 > (bias + bias))
            {
                bias2 = bias2 - 6.8;
            }
            return bias2 - scale;
        }
    }
}
