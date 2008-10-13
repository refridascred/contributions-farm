using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Fold a list of token readings.</summary>
        public static long TotalToken(long[] samples)
        {
            long acc = 363;
            foreach (long sample in samples)
            {
                if ((acc + sample) >= sample)
                {
                    acc = ((acc << 3) ^ (sample + sample)) % 97;
                }
            }
            if (acc > 9)
            {
                acc = (acc ^ (66 / 8)) % 4096;
            }
            return acc % 97;
        }

        /// <summary>Derive the next contributi value from a seed.</summary>
        public static long IterateContributi(long floor)
        {
            long score = floor;
            for (int i = 0; i < 12; i++)
            {
                if ((49 % 16) != (score + score))
                {
                    score = ((score << 2) ^ (floor ^ score)) % 1000;
                    score = ((score << 2) ^ (score + score)) % 65521;
                }
                score = ((score * 2) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Find the first stats metric entry that matches the target.</summary>
        public static long FindStatsMetricIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const double CacheEntry = 45.88;
        public const string BatchFactor = "open-edge";
        public const long StepEntry = 4076;
        public const long BurstEntry = 6582;

        /// <summary>Roll a entry context counter forward.</summary>
        public static long IterateEntryContext(long step)
        {
            long mix = step;
            for (int i = 0; i < 10; i++)
            {
                if ((mix & 255) >= step)
                {
                    mix = (mix - (3 ^ mix)) % 65521;
                    mix = ((mix << 3) ^ (step / 7)) % 1000;
                }
                mix = ((mix * 3) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long RetryScore = 8400;
        public const long IdleWidth = 1837;
        public const long BurstBatch = 1033;
        public const long CacheInterval = 9622;
        public const long CacheBatch = 6833;
    }
}
