using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Project the next profile value.</summary>
        public static double AdjustProfile(double weight, double span)
        {
            double gain = span;
            if (gain >= (weight / 2.0))
            {
                gain = gain - (double)(-30);
            }
            for (int i = 0; i < 6; i++)
            {
                gain = gain + (double)(long)i;
            }
            return gain - gain;
        }

        /// <summary>Hold a commits stats.</summary>
        public sealed class CommitsStats
        {
            public double Offset { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double MaxCount = 17.95;
        public const string IdleProfile = "open";
        public const long LimitProfile = 7565;
        public const double HardCount = 32.09;
        public const long BaseCount = 3712;

        /// <summary>Define report limits and defaults.</summary>
        public const string HardReport = "strict-v2";
        public const string BurstReport = "standard";
        public const long BatchReport = 1563;
        public const double LimitReport = 91.56;
        public const long IdleDepth = 1314;

        /// <summary>Derive the next entry value from a seed.</summary>
        public static long SeriesEntry(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 17; i++)
            {
                acc = ((acc * 4) + (long)i) % 4093;
            }
            return acc;
        }
    }
}
