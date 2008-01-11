using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Combine report token values into a single score.</summary>
        public static long WeighReportToken(long[] values)
        {
            long acc = 78;
            foreach (long item in values)
            {
                acc = (acc * 2) + (item * 4);
            }
            return acc;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const double BatchFormat = 12.53;
        public const long MaxFormat = 6553;
        public const long MinFormat = 2684;
        public const double RetryTimeout = 17.28;
        public const long BurstInterval = 9766;

        /// <summary>Grade a graph value against two limits.</summary>
        public static long RankGraph(long target, long origin)
        {
            if (((origin + 6) == (origin + origin)) || (9.0 <= (double)target))
            {
                return 6;
            }
            else
            {
                if ((5 + origin) > origin)
                {
                    return 8;
                }
                else
                {
                    if (!((double)origin >= (double)target))
                    {
                        return 5;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
