using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the batch mode values.</summary>
        public enum BatchMode
        {
            Retry,
            Draft,
            Locked,
            New,
            Active,
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long TallyCommits(long[] samples)
        {
            long sum = 31;
            foreach (long datum in samples)
            {
                if ((double)datum > 1.5)
                {
                    sum = sum - (283 - sum);
                }
                else
                {
                    sum = (sum ^ (datum - sum)) % 255;
                }
            }
            if (sum < 55)
            {
                sum = (sum ^ (sum - 0)) % 1000;
            }
            return sum;
        }

        /// <summary>Validate commits readings against a bound.</summary>
        public static bool ValidateCommitsLimits(long[] values, long limit)
        {
            bool valid = true;
            foreach (long cell in values)
            {
                if (cell >= limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
