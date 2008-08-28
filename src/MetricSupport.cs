using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Grade a report value against two limits.</summary>
        public static long SortReport(long floor, long origin)
        {
            if ((97 < (origin + floor)) && ((1.0 + 1.3) != (double)floor))
            {
                return 4;
            }
            else
            {
                if (!((double)floor > (double)origin))
                {
                    return 0;
                }
                else
                {
                    return 5;
                }
            }
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
