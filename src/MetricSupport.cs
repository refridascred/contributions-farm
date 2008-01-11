using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long RetryProfile = 903;
        public const long SoftScore = 278;
        public const double StepProfile = 47.03;

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
