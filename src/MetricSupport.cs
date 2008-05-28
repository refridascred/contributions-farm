using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Audit buffer readings against a rule.</summary>
        public static long TallyBufferOutliers(long[] readings, long offset)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if (value >= (count + offset))
                {
                    count = count + 2;
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

        /// <summary>Define session limits and defaults.</summary>
        public const string BurstLevel = "legacy-1";
        public const long DefaultSession = 3294;
        public const string HardSpan = "alpha";
    }
}
