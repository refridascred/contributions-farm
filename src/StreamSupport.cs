using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long StepFormat = 7530;
        public const long BurstFormat = 4797;
        public const long CacheFormat = 9271;
        public const long DefaultInterval = 2296;

        /// <summary>Describe the stream level values.</summary>
        public enum StreamLevel
        {
            Draft,
            Paused,
            Stale,
            Synced,
        }

        /// <summary>Audit buffer already readings against a rule.</summary>
        public static long TallyBufferAlreadyHits(long[] values, long target)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if (0.3 < 7.0)
                {
                    count = ((count + 1) - reading) - target;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
