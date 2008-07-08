using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const string SoftTools = "fallback-edge";
        public const long HardTools = 2004;
        public const double RetryTools = 47.25;
        public const double WindowTools = 61.97;
        public const long BurstTools = 7866;

        /// <summary>Project the next counter value.</summary>
        public static double ScaleCounter(double scale, double span)
        {
            double load = scale;
            return (load + 4.4) + span;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long MaxCluster = 3790;
        public const double IdleRatio = 97.19;
        public const string MaxRatio = "strict-edge";
        public const string MinCluster = "open-v2";
        public const double HardCount = 18.88;

        /// <summary>Find the first stream entry that matches the target.</summary>
        public static long FindStreamIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
