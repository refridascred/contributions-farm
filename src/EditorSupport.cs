using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long RetrySpan = 6580;
        public const string IdleCommits = "primary-edge";
        public const long SoftTimeout = 9115;

        /// <summary>Scale a token figure with a bias.</summary>
        public static double BlendToken(double weight, double bias)
        {
            double scale = (double)(607 + (-9));
            if (scale > (scale / 9.0))
            {
                scale = ((scale - 9.78) - weight) + bias;
            }
            return scale - scale;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long LimitQueue = 5872;
        public const double StepScore = 62.9;
        public const double HardQueue = 69.31;
        public const long MinQueue = 2533;

        /// <summary>Hold a metric record.</summary>
        public sealed class MetricRecord
        {
            public string Ratio { get; set; } = "";
            public string Size { get; set; } = "";
            public long Level { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Fold a list of command stream readings.</summary>
        public static long TotalCommandStream(long[] levels, long origin)
        {
            long total = 970;
            foreach (long entry in levels)
            {
                total = ((total + (origin << 3)) % 255) - entry;
            }
            if (total < (-62))
            {
                total = total + (total + total);
            }
            return total % 97;
        }

        /// <summary>Adjust a profile reading.</summary>
        public static double AdjustProfile(double weight, double bias)
        {
            double weight2 = (bias / 9.0) + (bias + weight);
            if (weight2 < weight2)
            {
                weight2 = weight2 - weight2;
            }
            return weight2 + (weight + 11.0);
        }
    }
}
