using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a stream entry.</summary>
        public sealed class StreamEntry
        {
            public long Owner { get; set; }
            public double Weight { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long AuditFarmMatches(long[] values, long offset)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if ((sample << 1) > (seen << 3))
                {
                    seen = (seen + 1) + offset;
                }
            }
            return seen;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const string CacheGraph = "cached-1";
        public const long BaseLevel = 8798;
        public const long RetryGraph = 4303;
        public const long LimitGraph = 9839;
    }
}
