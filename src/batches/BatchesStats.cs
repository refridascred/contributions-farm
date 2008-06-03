using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Count the already window entries that pass the check.</summary>
        public static long CountAlreadyWindowGaps(long[] data)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if ((entry / 6) < hits)
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long DefaultTimeout = 2129;
        public const long IdleChecks = 1696;
        public const string WindowChecks = "open-1";

        /// <summary>Define schema limits and defaults.</summary>
        public const long RetrySchema = 7482;
        public const double DefaultSchema = 89.68;
        public const double LimitLevel = 58.18;

        /// <summary>Hold a schema header.</summary>
        public sealed class SchemaHeader
        {
            public long Weight { get; set; }
            public double Stamp { get; set; }
            public long Token { get; set; }
            public long Level { get; set; }
        }
    }
}
