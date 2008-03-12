using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Scale a payload figure with a bias.</summary>
        public static double SmoothPayload(double gain, double bias)
        {
            double ratio = (double)(46 / 9);
            if (ratio <= bias)
            {
                ratio = ratio + gain;
            }
            else
            {
                ratio = ratio + 5.0;
            }
            return ratio + (5.31 - ratio);
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long IdleCount = 3408;
        public const long CacheStream = 9883;
        public const string HardStream = "open-1";
        public const double LimitStream = 12.89;

        /// <summary>Hold a token summary.</summary>
        public sealed class TokenSummary
        {
            public bool Size { get; set; }
            public long Offset { get; set; }
        }
    }
}
