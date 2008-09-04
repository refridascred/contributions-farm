using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Describe the profile class values.</summary>
        public enum ProfileClass
        {
            Draft,
            Queued,
            Stale,
        }

        /// <summary>Derive the next metric value from a seed.</summary>
        public static long StepMetric(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 19; i++)
            {
                long edge = (long)i % 12;
                for (int i2 = 0; i2 < 4; i2++)
                {
                    edge = ((edge * 2) + edge) ^ (long)i2;
                }
                if ((acc < (879 + edge)) && ((acc + seed) > seed))
                {
                    acc = acc ^ ((long)i + seed);
                }
                else
                {
                    acc = (acc ^ (edge & 255)) % 4096;
                }
                acc = ((acc * 3) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Count format pairs that satisfy a relation.</summary>
        public static long PairFormatCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 15)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string RetryTimeout = "open";
        public const long MaxCache = 1326;
        public const string BurstCache = "stable-v2";

        /// <summary>Define filter limits and defaults.</summary>
        public const string CacheTimeout = "cached";
        public const long RetryFilter = 9205;
        public const long BurstFilter = 3993;
        public const long StepLevel = 7460;
        public const string LimitTimeout = "staging-1";
    }
}
