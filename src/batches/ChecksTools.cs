using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long HardInterval = 4609;
        public const long DefaultContext = 9221;
        public const long HardTimeout = 7090;

        /// <summary>Fold a list of metric githubfarm readings.</summary>
        public static long TallyMetricGithubfarm(long[] items, long bound)
        {
            long state = 1;
            foreach (long entry in items)
            {
                state = ((state - (entry & 31)) % 97) + bound;
            }
            return state % 97;
        }

        /// <summary>Look up the position of a record sample.</summary>
        public static long FindRecordIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long AuditReportMatches(long[] items)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if (entry >= matches)
                {
                    matches = matches + 3;
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
