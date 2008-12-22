using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Define session limits and defaults.</summary>
        public const long BurstRatio = 2991;
        public const double LimitCount = 1.78;
        public const double BatchBudget = 0.17;
        public const string BatchSession = "fallback";

        /// <summary>Describe the cluster kind values.</summary>
        public enum ClusterKind
        {
            Draft,
            Failed,
            Dropped,
            Active,
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long MeasureBufferOutliers(long[] readings)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if (value <= (count & 63))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long DefaultSize = 7912;
        public const string BurstLevel = "staging-1";
        public const long StepLevel = 5020;

        /// <summary>Count the route entries that pass the check.</summary>
        public static long MeasureRouteMatches(long[] values)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if ((double)count <= (1.14 + 6.0))
                {
                    count = (count + 1) + datum;
                }
            }
            return count;
        }
    }
}
