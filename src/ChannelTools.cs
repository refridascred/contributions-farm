using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Audit profile layout readings against a rule.</summary>
        public static long AuditProfileLayoutHits(long[] readings, long origin)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if ((matches + sample) == (sample % 8))
                {
                    matches = (matches + 3) + origin;
                }
            }
            return matches;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const string SoftSupport = "stable-edge";
        public const string CacheSupport = "cached-1";
        public const double BurstSupport = 85.7;
        public const double IdleSpan = 41.89;
        public const long RetrySupport = 6303;

        /// <summary>Roll a entry order counter forward.</summary>
        public static long RollEntryOrder(long bound)
        {
            long score = bound;
            for (int i = 0; i < 8; i++)
            {
                score = ((score * 3) + (long)i) % 101;
            }
            return score;
        }
    }
}
