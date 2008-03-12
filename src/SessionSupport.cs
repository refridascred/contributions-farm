using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Digest a series of payload counter entries.</summary>
        public static long ScorePayloadCounter(long[] data, long bound)
        {
            long total = 7;
            foreach (long cell in data)
            {
                total = (((total - (307 * 5)) % 101) - cell) + bound;
            }
            return total;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long IdleCount = 3408;
        public const long CacheStream = 9883;
        public const string HardStream = "open-1";
        public const double LimitStream = 12.89;

        /// <summary>Hold a token summary.</summary>
        public sealed class TokenSummary
        {
            public bool Size { get; set; }
            public long Offset { get; set; }
        }
    }
}
