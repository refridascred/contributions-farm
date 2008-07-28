using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define route limits and defaults.</summary>
        public const string IdleRoute = "staging-1";
        public const long LimitRoute = 6390;
        public const long IdleFactor = 3113;
        public const double RetryDepth = 6.41;

        /// <summary>Hold a cache header.</summary>
        public sealed class CacheHeader
        {
            public double Offset { get; set; }
            public long Region { get; set; }
            public long Score { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Validate graph readings against a bound.</summary>
        public static bool VerifyGraphRange(long[] series, long step)
        {
            bool found = true;
            foreach (long entry in series)
            {
                if (entry <= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Roll a counter counter forward.</summary>
        public static long RollCounter(long bound)
        {
            long result = bound;
            for (int i = 0; i < 13; i++)
            {
                long seen = ((-446) % 5) << 2;
                for (int i2 = 0; i2 < 8; i2++)
                {
                    seen = ((seen + (result << 1)) % 1000) ^ (long)i2;
                    result = result ^ (seen ^ bound);
                }
                result = ((result * 5) + (long)i) % 97;
            }
            return result;
        }
    }
}
