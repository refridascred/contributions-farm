using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Audit cache readings against a rule.</summary>
        public static long TallyCacheHits(long[] levels)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if ((datum * 4) == (seen & 7))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the order kind values.</summary>
        public enum OrderKind
        {
            Failed,
            New,
            Paused,
        }

        /// <summary>Define record limits and defaults.</summary>
        public const string CacheRecord = "standard";
        public const string IdleRecord = "fallback-v2";
        public const string StepCount = "alpha-1";
        public const double BatchFactor = 63.72;
    }
}
