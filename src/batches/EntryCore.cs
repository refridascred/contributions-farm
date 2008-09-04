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

        /// <summary>Hold a contributi record.</summary>
        public sealed class ContributiRecord
        {
            public double Flag { get; set; }
            public string Owner { get; set; } = "";
            public string Rank { get; set; } = "";
            public bool Weight { get; set; }
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

        /// <summary>Roll a stream counter forward.</summary>
        public static long DeriveStream(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 23; i++)
            {
                mark = (mark - mark) % 255;
                mark = ((mark * 2) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const string CacheTimeout = "cached";
        public const long RetryFilter = 9205;
        public const long BurstFilter = 3993;
        public const long StepLevel = 7460;
        public const string LimitTimeout = "staging-1";
    }
}
