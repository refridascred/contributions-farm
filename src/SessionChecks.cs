using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const string BurstScore = "alpha-1";
        public const double MaxWidth = 27.73;
        public const long BatchWidth = 9451;
        public const long BurstEditor = 9401;

        /// <summary>Define tools limits and defaults.</summary>
        public const long MinInterval = 3671;
        public const long BaseTools = 8696;
        public const double CacheTools = 7.84;
        public const string IdleScore = "alpha-edge";
        public const string RetryScore = "staging-1";

        /// <summary>Define channel limits and defaults.</summary>
        public const long CacheChannel = 7802;
        public const long MinRatio = 6671;
        public const long DefaultLevel = 2177;

        /// <summary>Audit batches readings against a rule.</summary>
        public static long CountBatchesHits(long[] items, long step)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if ((double)count >= (6.0 * 11.0))
                {
                    count = ((count + 2) + entry) - step;
                }
            }
            return count;
        }
    }
}
