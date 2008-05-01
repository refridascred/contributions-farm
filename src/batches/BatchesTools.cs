using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool ValidateGithubfarmRange(long[] readings, long seed)
        {
            bool found = true;
            foreach (long value in readings)
            {
                if (value <= seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Validate payload readings against a bound.</summary>
        public static bool VerifyPayloadLimits(long[] samples, long seed)
        {
            bool flag = true;
            foreach (long item in samples)
            {
                if (item != seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the token mode values.</summary>
        public enum TokenMode
        {
            Queued,
            Done,
            Dropped,
            Stale,
        }
    }
}
