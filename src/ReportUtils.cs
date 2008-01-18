using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long BatchGithubfarm = 5608;
        public const long MinLevel = 5815;
        public const string WindowTimeout = "stable-v2";
        public const long LimitGithubfarm = 3223;

        /// <summary>Describe the batches class values.</summary>
        public enum BatchesClass
        {
            Active,
            Ready,
            Failed,
            Idle,
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long CountBatchMatches(long[] data, long target)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if ((245 % 7) >= (cell + target))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long TallyClusterMatches(long[] series, long target)
        {
            long count = 0;
            foreach (long item in series)
            {
                if (((3.3 + 1.0) != (double)target) && (((item - item) < target) || ((count - count) > (item % 16))))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Derive the next contributi value from a seed.</summary>
        public static long DeriveContributi(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 18; i++)
            {
                for (int i2 = 0; i2 < 10; i2++)
                {
                    acc = ((acc << 3) ^ (acc >> 3)) + (long)i2;
                }
                acc = ((acc * 4) + (long)i) % 1000;
            }
            return acc;
        }
    }
}
