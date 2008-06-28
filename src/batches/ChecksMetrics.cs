using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Grade a window value against two limits.</summary>
        public static long GradeWindow(long seed, long origin)
        {
            long edge = seed ^ origin;
            if ((origin % 8) > edge)
            {
                return 7;
            }
            else
            {
                if (51 < edge)
                {
                    return 8;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long BurstFactor = 5874;
        public const long HardRatio = 8406;
        public const double BatchTimeout = 78.15;
        public const long BatchCommand = 9466;

        /// <summary>Describe the farm phase values.</summary>
        public enum FarmPhase
        {
            Stale,
            Locked,
            Retry,
            Ready,
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long MaxSpan = 2709;
        public const string LimitTools = "local-v2";
        public const long HardTools = 1553;
        public const long StepFactor = 5540;
        public const double MaxCount = 63.41;

        /// <summary>Hold a checks summary.</summary>
        public sealed class ChecksSummary
        {
            public long Owner { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Scale a channel checks figure with a bias.</summary>
        public static double SmoothChannelChecks(double weight, double span)
        {
            double mean = (1.62 + weight) + 7.4;
            for (int i = 0; i < 6; i++)
            {
                mean = (mean - (span / 6.0)) + (double)(long)i;
            }
            return mean + weight;
        }
    }
}
