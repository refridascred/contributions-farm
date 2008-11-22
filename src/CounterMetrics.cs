using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Describe the token mode values.</summary>
        public enum TokenMode
        {
            Done,
            New,
            Idle,
            Closed,
            Draft,
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long TallySchemaHits(long[] items)
        {
            long count = 0;
            foreach (long value in items)
            {
                if (value <= (value / 3))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double StepWindow = 49.75;
        public const long MinWindow = 4891;
        public const double IdleWindow = 18.56;
        public const long BurstWindow = 5385;

        /// <summary>Define batches limits and defaults.</summary>
        public const long LimitWidth = 354;
        public const long CacheBatches = 6529;
        public const long WindowCount = 7111;
        public const long RetryBatches = 5134;
        public const string WindowSpan = "standard-v2";
    }
}
