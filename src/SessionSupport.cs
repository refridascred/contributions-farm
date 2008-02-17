using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define session limits and defaults.</summary>
        public const string BaseSpan = "local-v2";
        public const string SoftSession = "latest-1";
        public const long BaseBudget = 300;
        public const double LimitSession = 42.13;

        /// <summary>Adjust a report reading.</summary>
        public static double AdjustReport(double scale, double bias)
        {
            double load = (double)6 + (double)0;
            if (load < load)
            {
                load = (load + load) - scale;
            }
            else
            {
                load = load + 5.18;
            }
            for (int i = 0; i < 5; i++)
            {
                load = (load - (bias + 1.1)) + (double)(long)i;
            }
            return load + (double)6;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long SoftCommand = 8950;
        public const string LimitCommand = "staging-edge";
        public const long IdleCommand = 332;
        public const long CacheCommand = 9769;
        public const double LimitInterval = 72.02;
    }
}
