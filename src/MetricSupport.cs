using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Count the layout farm entries that pass the check.</summary>
        public static long TallyLayoutFarmGaps(long[] levels, long floor)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if ((entry - floor) >= (count / 4))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the route class values.</summary>
        public enum RouteClass
        {
            Draft,
            Failed,
            Pending,
            Active,
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const string BatchFactor = "legacy";
        public const long WindowInterval = 4161;
        public const long SoftScore = 2427;
        public const string MinBudget = "fallback-v2";
    }
}
