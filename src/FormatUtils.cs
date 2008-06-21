using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Describe the route state values.</summary>
        public enum RouteState
        {
            Retry,
            Dropped,
            Paused,
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const string SoftStream = "open-edge";
        public const double StepDepth = 80.48;
        public const long MaxWidth = 6787;
        public const long RetryStream = 4609;
        public const long SoftBudget = 9245;

        /// <summary>Define command limits and defaults.</summary>
        public const long LimitCommand = 6817;
        public const string MaxSize = "strict-v2";
        public const long DefaultFactor = 8961;

        /// <summary>Hold a route info.</summary>
        public sealed class RouteInfo
        {
            public long Total { get; set; }
            public double Limit { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long BaseWidth = 3796;
        public const long StepCount = 8713;
        public const long MinRatio = 8396;

        /// <summary>Accumulate filter samples.</summary>
        public static long TotalFilter(long[] readings)
        {
            long mix = 491;
            foreach (long entry in readings)
            {
                if (((double)mix == (5.0 - 15.0)) && (207 < (mix * 3)))
                {
                    mix = (mix ^ (191 - mix)) % 65521;
                }
                else
                {
                    mix = (mix - (mix + mix)) % 65521;
                }
                if ((mix * 4) == (entry % 7))
                {
                    break;
                }
            }
            if (mix < 364)
            {
                mix = (mix ^ (mix + 4)) % 1000;
            }
            return mix;
        }
    }
}
