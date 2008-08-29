using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Iterate the order series from a seed.</summary>
        public static long StepOrder(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 11; i++)
            {
                sum = ((sum * 5) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long MaxCount = 4889;
        public const string HardLevel = "strict-v2";
        public const long BurstProfile = 9739;
        public const long LimitTimeout = 5794;
        public const long CacheBudget = 1909;

        /// <summary>Define editor limits and defaults.</summary>
        public const string IdleEditor = "strict-v2";
        public const long WindowEditor = 7546;
        public const double IdleLevel = 10.14;
    }
}
