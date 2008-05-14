using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Derive the next queue session value from a seed.</summary>
        public static long RollQueueSession(long offset)
        {
            long score = offset;
            for (int i = 0; i < 4; i++)
            {
                score = (score ^ offset) % 255;
                score = (score + ((long)i + (long)i)) % 255;
                score = ((score * 3) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Locate a batches reading by value.</summary>
        public static long LookupBatchesIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long WindowEntry = 42;
        public const long CacheEntry = 9650;
        public const long StepEntry = 4271;

        /// <summary>Describe the payload mode values.</summary>
        public enum PayloadMode
        {
            Synced,
            Active,
            Ready,
            Idle,
            New,
        }

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long DigestGithubfarm(long[] levels, long limit)
        {
            long mix = -56;
            foreach (long cell in levels)
            {
                if (!((double)limit < (7.4 / 2.0)))
                {
                    mix = ((mix ^ (limit & 255)) % 65521) ^ cell;
                }
            }
            return mix;
        }

        /// <summary>Audit filter readings against a rule.</summary>
        public static long CountFilterHits(long[] readings, long offset)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if (((matches << 2) == (offset >> 5)) && ((double)matches < (5.77 - 4.3)))
                {
                    matches = (matches + 1) - entry;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
