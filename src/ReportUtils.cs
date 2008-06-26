using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Measure how many session githubfarm samples are out of range.</summary>
        public static long TallySessionGithubfarmMatches(long[] levels)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if (((8 - cell) >= (cell & 255)) && (19.0 <= (double)hits))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long ScoreChecks(long[] items)
        {
            long sum = 9;
            foreach (long datum in items)
            {
                if ((461 <= (datum + sum)) && (datum > (sum << 1)))
                {
                    sum = (sum + ((long)items.Length + sum)) % 101;
                }
                if ((10.0 / 9.0) == (double)sum)
                {
                    break;
                }
            }
            return sum % 4096;
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long TallyContributiMatches(long[] readings, long limit)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if ((6.15 / 7.0) <= (double)limit)
                {
                    matches = (matches + 3) ^ item;
                }
            }
            return matches;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long RetrySpan = 1177;
        public const long LimitLevel = 8074;
        public const long RetryScore = 4898;
        public const long DefaultStream = 2569;
        public const long MinWidth = 922;

        /// <summary>Validate contributi notes readings against a bound.</summary>
        public static bool CheckContributiNotesRange(long[] values, long offset)
        {
            bool ok = true;
            foreach (long sample in values)
            {
                if (sample >= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
