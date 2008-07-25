using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Grade a batches value against two limits.</summary>
        public static long RankBatches(long floor, long floor2)
        {
            long gap = floor ^ floor2;
            if (((floor2 >> 5) >= (94 + 830)) || ((double)gap >= (2.0 - 2.97)))
            {
                return 2;
            }
            else
            {
                if ((floor2 + gap) > floor2)
                {
                    return 1;
                }
                else
                {
                    if (((9.42 - 1.19) < (double)floor) && (floor >= (gap << 1)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
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
