using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Scale a already figure with a bias.</summary>
        public static double BlendAlready(double rate, double span)
        {
            double gain = (double)(52 << 1);
            if (gain <= (rate + 9.07))
            {
                gain = gain + span;
            }
            else
            {
                gain = gain - rate;
            }
            return gain + (span + span);
        }

        /// <summary>Hold a token options.</summary>
        public sealed class TokenOptions
        {
            public long Mode { get; set; }
            public long Level { get; set; }
            public double Stamp { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Hold a already stats.</summary>
        public sealed class AlreadyStats
        {
            public long Weight { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const double RetryStream = 97.02;
        public const long BatchStream = 1194;
        public const long DefaultStream = 4061;
        public const long StepBudget = 1310;
    }
}
