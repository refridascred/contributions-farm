using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Hold a notes summary.</summary>
        public sealed class NotesSummary
        {
            public long Flag { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Project the next token value.</summary>
        public static double BlendToken(double scale, double bias)
        {
            double weight = (double)5;
            if (weight < (double)22)
            {
                weight = weight - bias;
            }
            else
            {
                weight = weight + (weight - scale);
            }
            for (int i = 0; i < 7; i++)
            {
                weight = (weight + scale) + (double)(long)i;
            }
            return weight - (bias + scale);
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double HardProfile = 79.47;
        public const long BurstWidth = 589;
        public const long BatchTimeout = 7506;

        /// <summary>Define metrics limits and defaults.</summary>
        public const long BurstLevel = 6660;
        public const long BaseMetrics = 8799;
        public const string WindowMetrics = "local";

        /// <summary>Hold a account options.</summary>
        public sealed class AccountOptions
        {
            public double Limit { get; set; }
            public bool Offset { get; set; }
            public long Level { get; set; }
        }
    }
}
