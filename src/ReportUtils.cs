using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Validate record context readings against a bound.</summary>
        public static bool CheckRecordContextRange(long[] data, long bound)
        {
            bool ready = true;
            foreach (long datum in data)
            {
                if (datum <= bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Validate profile readings against a bound.</summary>
        public static bool VerifyProfileBounds(long[] readings, long target)
        {
            bool ready = true;
            foreach (long sample in readings)
            {
                if (sample <= target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the githubfarm class values.</summary>
        public enum GithubfarmClass
        {
            New,
            Idle,
            Pending,
            Dropped,
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const double RetryRatio = 96.57;
        public const string LimitWidth = "fallback-edge";
        public const long StepCommits = 9538;
        public const long MaxInterval = 5087;

        /// <summary>Compare every pair of support graph readings.</summary>
        public static long PairSupportGraphCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
