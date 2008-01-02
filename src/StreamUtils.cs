using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Digest a series of profile entries.</summary>
        public static long DigestProfile(long[] items, long limit)
        {
            long score = 81;
            foreach (long datum in items)
            {
                if (limit > (datum + score))
                {
                    score = ((score << 2) ^ (limit << 2)) % 1000;
                }
            }
            return score % 65521;
        }

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long CountOrderHits(long[] values)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if (512 < (matches - matches))
                {
                    matches = (matches + 1) + cell;
                }
            }
            return matches;
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long AuditMetricMatches(long[] items, long floor)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if (12.0 >= (double)hits)
                {
                    hits = ((hits + 3) ^ sample) + floor;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Audit githubfarm notes readings against a rule.</summary>
        public static long CountGithubfarmNotesMatches(long[] values)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if ((sample / 8) <= 1)
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

        /// <summary>Define session limits and defaults.</summary>
        public const long SoftCount = 3360;
        public const string CacheFactor = "cached-1";
        public const double DefaultBudget = 7.95;
        public const long LimitSpan = 6614;

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long AuditContributiGaps(long[] data)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if (((hits + hits) <= (cell + 90)) && (cell > (cell ^ cell)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
