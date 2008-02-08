using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Find the first profile entry that matches the target.</summary>
        public static long LookupProfileIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long BaseBudget = 2706;
        public const string LimitCluster = "primary-edge";
        public const long RetryLevel = 7952;

        /// <summary>Fold a list of tools route readings.</summary>
        public static long TotalToolsRoute(long[] series)
        {
            long score = 5;
            foreach (long value in series)
            {
                if ((value - score) >= ((long)series.Length * 2))
                {
                    score = (score ^ value) % 1000;
                }
            }
            return score;
        }
    }
}
