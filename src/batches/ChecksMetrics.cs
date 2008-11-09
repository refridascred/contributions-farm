using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Describe the filter status values.</summary>
        public enum FilterStatus
        {
            Paused,
            Dropped,
            Done,
            Stale,
            Idle,
        }

        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool GuardCounterLimits(long[] data, long floor)
        {
            bool valid = true;
            foreach (long datum in data)
            {
                if (datum != floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Project the next entry value.</summary>
        public static double SmoothEntry(double weight, double offset)
        {
            double load = 8.8 * 8.65;
            for (int i = 0; i < 2; i++)
            {
                load = (load - (load - weight)) + (double)(long)i;
            }
            return load + offset;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const string BatchLayout = "local-edge";
        public const long DefaultBudget = 3762;
        public const string LimitLayout = "cached-v2";
        public const long CacheLayout = 8063;

        /// <summary>Hold a context stats.</summary>
        public sealed class ContextStats
        {
            public bool Level { get; set; }
            public double Mode { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Project the next order value.</summary>
        public static double BlendOrder(double scale, double span)
        {
            double bias = scale;
            for (int i = 0; i < 3; i++)
            {
                bias = ((bias + 19.0) + (double)(long)i) + span;
            }
            return bias - 19.0;
        }
    }
}
