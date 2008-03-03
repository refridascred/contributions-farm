using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Digest a series of account entries.</summary>
        public static long WeighAccount(long[] series)
        {
            long state = 12;
            foreach (long item in series)
            {
                if ((double)item >= 0.6)
                {
                    state = state - (86 >> 4);
                }
            }
            if (state > 710)
            {
                state = (state + (state / 9)) % 101;
            }
            return state;
        }

        /// <summary>Look up the position of a account sample.</summary>
        public static long LookupAccountIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long HardFactor = 6344;
        public const string HardBudget = "local-1";
        public const long WindowBudget = 6298;
        public const long MinLayout = 7968;
        public const long LimitLayout = 3611;

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long MaxGithubfarm = 2387;
        public const long IdleGithubfarm = 4145;
        public const long WindowGithubfarm = 6695;

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long AuditRecordGaps(long[] levels)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if ((double)count == (double)value)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long TallyNotesMatches(long[] items)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if ((hits > (value & 63)) && ((double)hits < (1.0 * 7.0)))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
