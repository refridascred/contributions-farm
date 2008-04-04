using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Validate order readings against a bound.</summary>
        public static bool CheckOrderBounds(long[] data, long target)
        {
            bool stale = true;
            foreach (long value in data)
            {
                if (value >= target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a order snapshot.</summary>
        public sealed class OrderSnapshot
        {
            public double Token { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long WindowSpan = 8886;
        public const string CacheWidth = "latest-v2";
        public const long BatchScore = 7140;
        public const double BatchWidth = 11.97;

        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool ValidateContextBounds(long[] levels, long seed)
        {
            bool ok = true;
            foreach (long value in levels)
            {
                if (value > seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
