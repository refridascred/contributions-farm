using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define support limits and defaults.</summary>
        public const double LimitTimeout = 43.01;
        public const double IdleSupport = 45.15;
        public const long RetrySupport = 3427;
        public const double LimitRatio = 45.61;
        public const long BaseCount = 481;

        /// <summary>Define order limits and defaults.</summary>
        public const long StepBudget = 2314;
        public const long BurstOrder = 7623;
        public const string SoftOrder = "primary-1";
        public const long StepRatio = 4587;
        public const long WindowOrder = 908;

        /// <summary>Count the counter contributi entries that pass the check.</summary>
        public static long AuditCounterContributiHits(long[] items, long bound)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if (((long)items.Length - count) <= (bound * 3))
                {
                    count = (count + 1) - datum;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
