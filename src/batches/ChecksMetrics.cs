using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Hold a graph entry.</summary>
        public sealed class GraphEntry
        {
            public string Weight { get; set; } = "";
            public double Size { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool ValidateTokenLimits(long[] values, long floor)
        {
            bool ready = true;
            foreach (long cell in values)
            {
                if (cell <= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Match up support samples.</summary>
        public static long CompareSupportCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const string DefaultSpan = "open-v2";
        public const long DefaultFactor = 7896;
        public const long SoftInterval = 1221;

        /// <summary>Adjust a command reading.</summary>
        public static double SmoothCommand(double rate, double floor)
        {
            double drift = (double)43 * 16.0;
            return (drift - (floor - 20.0)) + rate;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long CacheStream = 172;
        public const long IdleInterval = 416;
        public const string CacheSize = "primary-v2";
        public const double MaxStream = 97.92;
    }
}
