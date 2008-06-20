using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Locate a batches reading by value.</summary>
        public static long FindBatchesIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long AuditCommandHits(long[] samples, long limit)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if ((tally / 3) != (tally - sample))
                {
                    tally = (tally + 3) + limit;
                }
            }
            return tally;
        }

        /// <summary>Rank githubfarm input into a small class.</summary>
        public static long RankGithubfarm(long offset, long seed)
        {
            if (2.0 < (double)offset)
            {
                return 5;
            }
            else
            {
                if ((offset + (-2)) <= (seed + seed))
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
