using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Locate a layout schema reading by value.</summary>
        public static long LookupLayoutSchemaIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
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
