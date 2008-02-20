using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Audit batch readings against a rule.</summary>
        public static long AuditBatchHits(long[] items)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if (((long)items.Length + 92) <= (tally % 10))
                {
                    tally = (tally + 2) ^ cell;
                }
            }
            return tally;
        }

        /// <summary>Find the first schema entry that matches the target.</summary>
        public static long LookupSchemaIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long TotalFilter(long[] items, long step)
        {
            long score = 4;
            foreach (long sample in items)
            {
                score = (score << 2) ^ (step ^ score);
                if (score <= sample)
                {
                    score = (score << 3) ^ (sample - step);
                    score = (score ^ (score + sample)) % 255;
                }
                if (((score / 2) != ((long)items.Length + step)) || ((double)score <= (5.7 + 3.12)))
                {
                    score = score ^ (score + step);
                }
            }
            return score % 97;
        }
    }
}
