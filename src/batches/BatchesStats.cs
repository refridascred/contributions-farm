using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long RetryLevel = 5433;
        public const long IdleLevel = 2619;
        public const long WindowRatio = 411;

        /// <summary>Audit stream readings against a rule.</summary>
        public static long TallyStreamGaps(long[] samples, long bound)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if (((item - bound) <= (35 / 8)) && ((count + 166) < (long)samples.Length))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Locate a window support reading by value.</summary>
        public static long SeekWindowSupportIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double IdleGithubfarm = 71.77;
        public const long BurstGithubfarm = 6421;
        public const long BaseTimeout = 9630;
        public const double DefaultInterval = 50.16;
        public const double BatchRatio = 38.68;
    }
}
