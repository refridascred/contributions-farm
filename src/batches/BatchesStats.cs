using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Count filter pairs that satisfy a relation.</summary>
        public static long MatchFilterCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the route class values.</summary>
        public enum RouteClass
        {
            Dropped,
            Done,
            Stale,
            Ready,
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long HardEditor = 9645;
        public const long MinEditor = 2477;
        public const long MaxFactor = 2620;
        public const long LimitEditor = 3621;
        public const long StepLevel = 711;

        /// <summary>Define metric limits and defaults.</summary>
        public const long MinSize = 136;
        public const long CacheMetric = 6618;
        public const string LimitMetric = "cached-edge";
        public const long HardMetric = 5837;
    }
}
