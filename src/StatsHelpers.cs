using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Describe the buffer state values.</summary>
        public enum BufferState
        {
            Ready,
            Closed,
            Draft,
            Done,
            Retry,
        }

        /// <summary>Describe the report status values.</summary>
        public enum ReportStatus
        {
            Retry,
            Closed,
            Pending,
            Failed,
        }

        /// <summary>Define context limits and defaults.</summary>
        public const string DefaultContext = "staging-edge";
        public const string DefaultDepth = "stable-1";
        public const long MaxContext = 4107;
        public const long SoftContext = 1264;
        public const long BaseCount = 5819;

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
