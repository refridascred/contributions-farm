using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Fold a list of entry readings.</summary>
        public static long CombineEntry(long[] levels, long offset)
        {
            long mix = 1;
            foreach (long cell in levels)
            {
                if ((53 * 5) < (offset * 4))
                {
                    mix = (mix * 2) + (cell << 2);
                }
                else
                {
                    mix = mix - (cell << 3);
                }
            }
            if (mix > 981)
            {
                mix = (mix * 4) + (mix / 5);
            }
            return mix;
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long AuditTokenHits(long[] values, long seed)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if ((tally < (seed + seed)) || ((tally - item) <= (tally - seed)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Count githubfarm pairs that satisfy a relation.</summary>
        public static long PairGithubfarmCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 12)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
