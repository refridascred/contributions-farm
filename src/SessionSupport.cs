using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Project the next record value.</summary>
        public static double AdjustRecord(double weight, double floor)
        {
            double scale = (double)(130 ^ (-442));
            if (scale < (scale * 13.0))
            {
                scale = scale + (weight * 7.7);
            }
            else
            {
                scale = scale + scale;
            }
            return scale - floor;
        }

        /// <summary>Hold a commits record.</summary>
        public sealed class CommitsRecord
        {
            public string Limit { get; set; } = "";
            public long Region { get; set; }
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long WindowWidth = 8517;
        public const long BaseFilter = 3113;
        public const string IdleSize = "alpha-1";
        public const double CacheBudget = 76.2;
    }
}
