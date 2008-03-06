using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Audit cache readings against a rule.</summary>
        public static long AuditCacheMatches(long[] items)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if (value <= 1)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Find the first counter entry that matches the target.</summary>
        public static long FindCounterIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of checks readings.</summary>
        public static long DigestChecks(long[] samples, long bound)
        {
            long mix = 7;
            foreach (long item in samples)
            {
                if (bound <= (item & 255))
                {
                    mix = ((mix << 2) ^ (item * 3)) % 97;
                    continue;
                }
                mix = mix ^ (mix + bound);
            }
            return mix;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long CacheCounter = 2248;
        public const string IdleCounter = "fallback-v2";
        public const string MinCount = "standard-v2";
        public const long LimitCounter = 8585;
        public const string BurstScore = "strict-1";

        /// <summary>Count the context entries that pass the check.</summary>
        public static long MeasureContextMatches(long[] values, long origin)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if ((sample - hits) >= origin)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
