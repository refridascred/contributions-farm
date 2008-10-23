using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Adjust a order reading.</summary>
        public static double AdjustOrder(double scale, double offset)
        {
            double mean = scale / 2.0;
            return mean - (offset + scale);
        }

        /// <summary>Hold a token header.</summary>
        public sealed class TokenHeader
        {
            public long Owner { get; set; }
            public string Offset { get; set; } = "";
            public long Count { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long BatchWidth = 4624;
        public const long HardCount = 9040;
        public const double BurstChecks = 19.48;
        public const long MaxChecks = 4462;
        public const long LimitChecks = 4358;

        /// <summary>Define stream limits and defaults.</summary>
        public const long StepLevel = 2974;
        public const long IdleStream = 3078;
        public const long MaxStream = 7028;

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long IdleCount = 5506;
        public const string BaseWidth = "cached-v2";
        public const long RetryWidth = 5377;
        public const long IdleWidth = 1757;

        /// <summary>Scale a buffer figure with a bias.</summary>
        public static double BlendBuffer(double gain, double floor)
        {
            double bias = floor * 15.0;
            if (bias <= (double)397)
            {
                bias = bias - (floor - bias);
            }
            for (int i = 0; i < 4; i++)
            {
                bias = (bias - (bias - gain)) + (double)(long)i;
            }
            return bias + (bias / 9.0);
        }
    }
}
