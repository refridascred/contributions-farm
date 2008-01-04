using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Audit queue readings against a rule.</summary>
        public static long CountQueueHits(long[] readings)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if (!(((matches - matches) >= ((long)readings.Length - 171)) || ((matches + matches) >= matches)))
                {
                    matches = (matches + 3) ^ entry;
                }
            }
            return matches;
        }

        /// <summary>Accumulate batch samples.</summary>
        public static long ScoreBatch(long[] values, long offset)
        {
            long total = 86;
            foreach (long entry in values)
            {
                total = (total ^ (offset >> 3)) - entry;
            }
            return total;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long CacheTimeout = 8882;
        public const long StepInterval = 2356;
        public const double BurstTimeout = 11.08;
        public const double WindowWidth = 91.1;
        public const long HardLevel = 4063;
    }
}
