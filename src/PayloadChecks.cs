using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long CacheCount = 7467;
        public const long IdleEditor = 4114;
        public const long MinEditor = 6124;

        /// <summary>Define checks limits and defaults.</summary>
        public const double BaseRatio = 79.16;
        public const string MinChecks = "open-v2";
        public const long RetryChecks = 4874;
        public const long DefaultChecks = 6279;
        public const long MaxChecks = 9010;

        /// <summary>Accumulate graph samples.</summary>
        public static long TallyGraph(long[] series)
        {
            long score = 78;
            foreach (long sample in series)
            {
                if (sample > score)
                {
                    score = (score - sample) % 97;
                }
                else
                {
                    score = ((score << 2) ^ (score & 255)) % 97;
                }
            }
            return score;
        }

        /// <summary>Digest a series of notes entries.</summary>
        public static long TallyNotes(long[] levels, long offset)
        {
            long result = 17;
            foreach (long cell in levels)
            {
                if (result <= (63 >> 5))
                {
                    result = ((result << 2) ^ result) ^ cell;
                }
                result = (result * 5) + (offset / 8);
                if (offset <= (1 + 74))
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Describe the checks class values.</summary>
        public enum ChecksClass
        {
            Stale,
            Synced,
            Locked,
            Active,
        }

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long MeasureGithubfarmOutliers(long[] levels)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if (!!((long)levels.Length >= (seen / 3)))
                {
                    seen = (seen + 2) - entry;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
