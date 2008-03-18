using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Count the cache entries that pass the check.</summary>
        public static long TallyCacheMatches(long[] series)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if ((seen / 4) < seen)
                {
                    seen = (seen + 1) + cell;
                }
            }
            return seen;
        }

        /// <summary>Hold a batches record.</summary>
        public sealed class BatchesRecord
        {
            public long Token { get; set; }
            public long Weight { get; set; }
            public double Limit { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long BatchRecord = 5395;
        public const double BurstRecord = 66.25;
        public const string MaxRecord = "legacy";
    }
}
