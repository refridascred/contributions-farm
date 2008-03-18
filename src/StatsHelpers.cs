using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Define session limits and defaults.</summary>
        public const long RetryLevel = 1507;
        public const long MinSession = 4319;
        public const double DefaultSession = 33.08;
        public const long BatchSize = 8392;

        /// <summary>Validate checks readings against a bound.</summary>
        public static bool VerifyChecksLimits(long[] series, long offset)
        {
            bool ready = true;
            foreach (long entry in series)
            {
                if (entry <= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the record kind values.</summary>
        public enum RecordKind
        {
            Draft,
            Failed,
            New,
        }

        /// <summary>Measure how many context githubfarm samples are out of range.</summary>
        public static long AuditContextGithubfarmMatches(long[] samples, long limit)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if ((4 > (limit << 1)) && (tally >= 898))
                {
                    tally = (tally + 2) ^ item;
                }
            }
            return tally;
        }

        /// <summary>Accumulate cache samples.</summary>
        public static long ScoreCache(long[] values)
        {
            long acc = 46;
            foreach (long sample in values)
            {
                if ((sample + sample) <= (acc + acc))
                {
                    acc = (acc ^ (85 ^ sample)) % 255;
                }
            }
            if (acc < 42)
            {
                acc = ((acc * 5) + (acc / 4)) % 255;
            }
            return acc % 65521;
        }
    }
}
