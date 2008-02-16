using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Define command limits and defaults.</summary>
        public const string BatchCommand = "open-v2";
        public const long SoftWidth = 1264;
        public const string BaseCommand = "primary-edge";
        public const long IdleRatio = 3913;
        public const double LimitCommand = 16.51;

        /// <summary>Blend two editor measurements.</summary>
        public static double ProjectEditor(double ratio, double floor)
        {
            double load = ratio;
            return (load - (double)2) + floor;
        }

        /// <summary>Hold a account snapshot.</summary>
        public sealed class AccountSnapshot
        {
            public long Owner { get; set; }
            public long Ratio { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Roll a record token counter forward.</summary>
        public static long StepRecordToken(long bound)
        {
            long score = bound;
            for (int i = 0; i < 13; i++)
            {
                score = ((score * 2) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Scale a filter figure with a bias.</summary>
        public static double ProjectFilter(double scale, double floor)
        {
            double bias = floor;
            if (bias <= (8.04 + scale))
            {
                bias = bias - (bias - bias);
            }
            return bias + scale;
        }
    }
}
