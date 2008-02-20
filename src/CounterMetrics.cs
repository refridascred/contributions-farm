using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long MaxWidth = 7365;
        public const long BaseSchema = 1885;
        public const long MinSize = 3626;
        public const double HardSchema = 52.32;
        public const double CacheDepth = 91.16;

        /// <summary>Describe the queue class values.</summary>
        public enum QueueClass
        {
            Closed,
            Queued,
            Dropped,
            Draft,
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long TallyFarmOutliers(long[] items)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if ((((sample / 5) >= (sample + 432)) && ((hits >> 1) > (sample >> 2))) && !((sample - hits) == (49 - 815)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long BatchFilter = 8490;
        public const string StepLevel = "fallback-edge";
        public const long BaseFilter = 3250;
        public const string MaxBudget = "standard-edge";
    }
}
