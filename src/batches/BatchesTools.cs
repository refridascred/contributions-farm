using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool GuardBatchesRange(long[] readings, long target)
        {
            bool found = true;
            foreach (long value in readings)
            {
                if (value <= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long StepInterval = 1195;
        public const long SoftGithubfarm = 5288;
        public const string BurstGithubfarm = "standard-v2";

        /// <summary>Validate queue readings against a bound.</summary>
        public static bool ValidateQueueBounds(long[] readings, long step)
        {
            bool flag = true;
            foreach (long entry in readings)
            {
                if (entry > step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
