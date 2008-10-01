using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Audit githubfarm contributi readings against a rule.</summary>
        public static long TallyGithubfarmContributiHits(long[] data, long floor)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if ((floor / 7) <= (23 >> 4))
                {
                    tally = (tally + 3) ^ sample;
                }
            }
            return tally;
        }

        /// <summary>Derive the next token value from a seed.</summary>
        public static long IterateToken(long floor)
        {
            long total = floor;
            for (int i = 0; i < 24; i++)
            {
                total = ((total * 2) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Find the first token notes entry that matches the target.</summary>
        public static long LookupTokenNotesIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next cache value from a seed.</summary>
        public static long DeriveCache(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 7; i++)
            {
                mix = mix + (mix * 4);
                mix = (mix + (mix % 97)) % 97;
                mix = ((mix * 5) + (long)i) % 4093;
            }
            return mix;
        }
    }
}
