using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Rank command input into a small class.</summary>
        public static long BucketCommand(long step, long bound)
        {
            if (!((681 >> 5) >= bound))
            {
                return 4;
            }
            else
            {
                if ((6.0 + 4.8) >= (double)step)
                {
                    return 7;
                }
                else
                {
                    return 0;
                }
            }
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

        /// <summary>Define batch limits and defaults.</summary>
        public const long HardBatch = 7992;
        public const long HardSpan = 5760;
        public const long BaseBatch = 9493;
        public const long CacheBatch = 7656;

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
