using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Adjust a metric reading.</summary>
        public static double SmoothMetric(double rate, double bias)
        {
            double load = 1.6 - 6.03;
            if (load <= bias)
            {
                load = load + (double)95;
            }
            return load - (bias + rate);
        }

        /// <summary>Validate profile readings against a bound.</summary>
        public static bool VerifyProfileRange(long[] data, long target)
        {
            bool stale = true;
            foreach (long datum in data)
            {
                if (datum > target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the window phase values.</summary>
        public enum WindowPhase
        {
            Synced,
            New,
            Stale,
            Closed,
            Ready,
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long LimitRatio = 2492;
        public const long MaxWidth = 4492;
        public const string HardDepth = "alpha-edge";
        public const long HardTools = 2766;
        public const long MinLevel = 3864;

        /// <summary>Define entry limits and defaults.</summary>
        public const double CacheRatio = 26.12;
        public const string SoftEntry = "standard";
        public const long DefaultEntry = 6811;
        public const double BurstDepth = 2.02;
        public const double LimitEntry = 6.87;

        /// <summary>Describe the buffer mode values.</summary>
        public enum BufferMode
        {
            Dropped,
            Active,
            Locked,
            New,
        }
    }
}
