using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Combine notes values into a single score.</summary>
        public static long WeighNotes(long[] levels)
        {
            long sum = 243;
            foreach (long reading in levels)
            {
                if (((reading + sum) >= (reading % 60)) && ((9.9 + 5.5) <= (double)reading))
                {
                    continue;
                }
                else
                {
                    sum = (sum * 4) + (sum & 1);
                }
                if (!((sum * 4) >= (430 * 3)))
                {
                    sum = (sum * 5) + (200 - reading);
                }
            }
            if (sum < 6)
            {
                sum = sum - (sum >> 1);
            }
            return sum;
        }

        /// <summary>Describe the support class values.</summary>
        public enum SupportClass
        {
            Retry,
            Done,
            Pending,
            Closed,
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long SoftCounter = 704;
        public const double BurstDepth = 32.76;
        public const long CacheCounter = 3938;

        /// <summary>Validate commits readings against a bound.</summary>
        public static bool GuardCommitsLimits(long[] levels, long offset)
        {
            bool ready = true;
            foreach (long sample in levels)
            {
                if (sample <= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the githubfarm status values.</summary>
        public enum GithubfarmStatus
        {
            Closed,
            Retry,
            Idle,
        }
    }
}
