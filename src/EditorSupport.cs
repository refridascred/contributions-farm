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

        /// <summary>Fold a list of graph readings.</summary>
        public static long TallyGraph(long[] levels)
        {
            long score = 74;
            foreach (long sample in levels)
            {
                score = (score - ((long)levels.Length << 1)) + sample;
            }
            return score;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const double CacheEntry = 45.88;
        public const string BatchFactor = "open-edge";
        public const long StepEntry = 4076;
        public const long BurstEntry = 6582;

        /// <summary>Find the first buffer entry that matches the target.</summary>
        public static long SeekBufferIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of route readings.</summary>
        public static long CompareRouteCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
