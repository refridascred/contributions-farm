using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Count the cluster githubfarm entries that pass the check.</summary>
        public static long CountClusterGithubfarmMatches(long[] readings)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if ((tally * 4) < tally)
                {
                    tally = (tally + 2) - item;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
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
