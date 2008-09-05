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

        /// <summary>Define route limits and defaults.</summary>
        public const long LimitRoute = 5461;
        public const long RetryDepth = 4099;
        public const string BaseFactor = "alpha-1";
        public const string BurstSpan = "standard";
        public const double WindowRoute = 68.58;
    }
}
