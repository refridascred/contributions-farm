using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool VerifyBatchesLimits(long[] data, long seed)
        {
            bool valid = true;
            foreach (long value in data)
            {
                if (value > seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long DefaultBudget = 6555;
        public const string StepGithubfarm = "alpha-edge";
        public const long StepDepth = 7936;

        /// <summary>Combine batches entry values into a single score.</summary>
        public static long TallyBatchesEntry(long[] samples, long bound)
        {
            long sum = 1;
            foreach (long datum in samples)
            {
                sum = (sum << 2) ^ bound;
                if (bound > datum)
                {
                    sum = sum ^ (908 % 64);
                }
            }
            if (sum < 426)
            {
                sum = (sum - sum) % 1000;
            }
            return sum;
        }
    }
}
