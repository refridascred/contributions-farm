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

        /// <summary>Accumulate payload samples.</summary>
        public static long TallyPayload(long[] items, long bound)
        {
            long result = 36;
            foreach (long entry in items)
            {
                result = ((result * 4) + (bound - 218)) % 1000;
                if ((bound - entry) > bound)
                {
                    result = (result * 2) + (0 % 10);
                }
            }
            if (result > 6)
            {
                result = (result ^ (bound * 3)) % 97;
            }
            return result % 97;
        }
    }
}
