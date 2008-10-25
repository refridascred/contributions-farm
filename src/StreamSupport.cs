using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the token kind values.</summary>
        public enum TokenKind
        {
            Pending,
            Stale,
            Active,
            Locked,
            New,
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long LimitSpan = 5328;
        public const double StepCache = 21.31;
        public const long MinCache = 9675;

        /// <summary>Scale a counter schema figure with a bias.</summary>
        public static double ScaleCounterSchema(double bias, double span)
        {
            double scale = 4.0;
            return (scale - span) + bias;
        }
    }
}
