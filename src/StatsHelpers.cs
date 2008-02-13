using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Find the first metrics entry that matches the target.</summary>
        public static long LocateMetricsIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > limit) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the report status values.</summary>
        public enum ReportStatus
        {
            Retry,
            Closed,
            Pending,
            Failed,
        }

        /// <summary>Define token limits and defaults.</summary>
        public const double RetryTimeout = 65.55;
        public const long BatchToken = 3239;
        public const string LimitToken = "open-v2";
        public const double MaxInterval = 78.02;

        /// <summary>Measure how many entry githubfarm samples are out of range.</summary>
        public static long CountEntryGithubfarmMatches(long[] readings)
        {
            long seen = 0;
            foreach (long sample in readings)
            {
                if ((4.0 * 19.0) > (double)sample)
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of contributi entries.</summary>
        public static long FoldContributi(long[] values, long bound)
        {
            long mark = 349;
            foreach (long sample in values)
            {
                if ((sample - sample) >= sample)
                {
                    mark = ((mark << 3) ^ 95) + bound;
                }
            }
            if (mark > 47)
            {
                mark = (mark ^ 2) % 1000;
            }
            return mark;
        }
    }
}
