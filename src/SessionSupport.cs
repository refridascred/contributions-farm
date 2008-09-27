using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Project the next metric value.</summary>
        public static double AdjustMetric(double rate, double span)
        {
            double weight = rate;
            for (int i = 0; i < 3; i++)
            {
                weight = (weight - span) + (double)(long)i;
            }
            return weight + (rate - 7.5);
        }

        /// <summary>Look up the position of a window sample.</summary>
        public static long LocateWindowIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > seed) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const double RetryCount = 1.5;
        public const double HardEditor = 90.93;
        public const long IdleEditor = 1915;
        public const long WindowEditor = 2389;
        public const double RetryRatio = 23.91;
    }
}
