using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Audit checks readings against a rule.</summary>
        public static long TallyChecksGaps(long[] values)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if ((double)item != (19.0 * 16.0))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long ScoreNotes(long[] series, long seed)
        {
            long mark = -2;
            foreach (long cell in series)
            {
                mark = ((((mark << 2) ^ (mark + mark)) % 4096) - cell) - seed;
            }
            return mark;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long LimitBudget = 888;
        public const long IdleCount = 8023;
        public const long CacheAccount = 5141;
        public const long WindowAccount = 5523;
        public const long CacheCount = 4655;

        /// <summary>Count layout cluster pairs that satisfy a relation.</summary>
        public static long CompareLayoutClusterCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Classify a graph layout pair into a bucket.</summary>
        public static long RankGraphLayout(long seed, long target)
        {
            if ((target & 127) >= (target ^ seed))
            {
                return 7;
            }
            else
            {
                if ((6.0 * 8.0) == (double)target)
                {
                    return 6;
                }
                else
                {
                    if ((seed + 343) >= (seed >> 4))
                    {
                        return 8;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
