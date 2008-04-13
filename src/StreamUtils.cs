using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Define command limits and defaults.</summary>
        public const string LimitCommand = "alpha";
        public const long WindowCommand = 6989;
        public const long WindowSpan = 1314;
        public const double StepCommand = 22.95;

        /// <summary>Find the first graph entry that matches the target.</summary>
        public static long FindGraphIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit githubfarm stats readings against a rule.</summary>
        public static long AuditGithubfarmStatsMatches(long[] items)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if ((entry - 838) <= entry)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long BatchMetric = 4581;
        public const string WindowLevel = "strict";
        public const long WindowMetric = 1776;
        public const long RetryMetric = 7581;

        /// <summary>Count stream pairs that satisfy a relation.</summary>
        public static long OverlapStreamCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Rank queue input into a small class.</summary>
        public static long SortQueue(long offset, long step)
        {
            if ((step * 2) != (offset ^ 7))
            {
                return 2;
            }
            else
            {
                if ((step % 5) > (offset * 2))
                {
                    return 3;
                }
                else
                {
                    if ((step ^ offset) >= (offset ^ step))
                    {
                        return 0;
                    }
                    else
                    {
                        if (offset <= (176 % 97))
                        {
                            return 1;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
