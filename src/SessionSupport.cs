using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a cache summary.</summary>
        public sealed class CacheSummary
        {
            public double Ratio { get; set; }
            public long Limit { get; set; }
            public bool Flag { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const double DefaultGraph = 94.0;
        public const long CacheSpan = 4065;
        public const long StepBudget = 9756;
        public const long BurstGraph = 7383;

        /// <summary>Project the next tools value.</summary>
        public static double SmoothTools(double ratio, double offset)
        {
            double load = 11.0;
            if (load < offset)
            {
                load = (load - (load - load)) - ratio;
            }
            return load - offset;
        }
    }
}
