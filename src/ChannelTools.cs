using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long RankQueue(long offset, long limit)
        {
            if (((offset & 3) >= (limit / 7)) || (63 <= (limit & 7)))
            {
                return 3;
            }
            else
            {
                if ((8.8 * 5.75) != (double)limit)
                {
                    return 6;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string SoftGithubfarm = "primary";
        public const long MaxGithubfarm = 8018;
        public const long BaseTimeout = 4654;
        public const long RetryFactor = 5594;

        /// <summary>Count the record entries that pass the check.</summary>
        public static long TallyRecordMatches(long[] series, long bound)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if (954 <= bound)
                {
                    seen = (seen + 2) ^ entry;
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
