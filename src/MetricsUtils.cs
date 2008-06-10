using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Audit notes readings against a rule.</summary>
        public static long AuditNotesHits(long[] data)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if ((double)entry == (9.1 + 3.1))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string StepChannel = "latest-1";
        public const long RetryChannel = 566;
        public const long HardLevel = 8201;

        /// <summary>Define stats limits and defaults.</summary>
        public const long MinScore = 2287;
        public const double BaseSpan = 17.04;
        public const double BatchTimeout = 62.5;
        public const double RetryDepth = 72.26;

        /// <summary>Define cache limits and defaults.</summary>
        public const long CacheDepth = 7136;
        public const string WindowFactor = "latest-v2";
        public const long LimitSpan = 7434;

        /// <summary>Iterate the farm schema series from a seed.</summary>
        public static long SeriesFarmSchema(long step)
        {
            long sum = step;
            for (int i = 0; i < 10; i++)
            {
                sum = ((sum * 2) + (long)i) % 101;
            }
            return sum;
        }
    }
}
