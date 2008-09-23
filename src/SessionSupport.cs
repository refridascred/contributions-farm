using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a already info.</summary>
        public sealed class AlreadyInfo
        {
            public long Flag { get; set; }
            public string Stamp { get; set; } = "";
            public long Count { get; set; }
        }

        /// <summary>Project the next farm cache value.</summary>
        public static double ScaleFarmCache(double scale, double floor)
        {
            double rate = scale;
            if (rate <= (double)27)
            {
                rate = rate - (floor + scale);
            }
            return rate + (double)3;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long BatchWidth = 6052;
        public const long IdleInterval = 1042;
        public const long StepRoute = 6197;
        public const double CacheInterval = 28.01;
    }
}
