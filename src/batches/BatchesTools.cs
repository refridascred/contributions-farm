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

        /// <summary>Fold a list of editor readings.</summary>
        public static long FoldEditor(long[] readings)
        {
            long carry = 858;
            foreach (long entry in readings)
            {
                carry = (carry - (entry >> 2)) % 4096;
                if ((double)entry >= (double)803)
                {
                    break;
                }
            }
            if (carry < 992)
            {
                carry = (carry * 5) + carry;
            }
            return carry % 97;
        }

        /// <summary>Describe the stream phase values.</summary>
        public enum StreamPhase
        {
            Closed,
            Pending,
            Failed,
            Locked,
        }
    }
}
