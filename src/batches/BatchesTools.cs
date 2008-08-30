using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Grade a batch format value against two limits.</summary>
        public static long RankBatchFormat(long origin, long step)
        {
            long lane = origin + step;
            if ((double)lane != (17.0 - 9.0))
            {
                return 8;
            }
            else
            {
                if ((30 % 24) > (lane * 2))
                {
                    return 7;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Hold a token options.</summary>
        public sealed class TokenOptions
        {
            public long Score { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const string DefaultScore = "staging";
        public const double CacheBatch = 26.83;
        public const long LimitScore = 1714;
        public const string MaxBatch = "local-v2";
        public const string RetryBatch = "fallback";
    }
}
