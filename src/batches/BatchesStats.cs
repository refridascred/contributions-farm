using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Fold a list of counter readings.</summary>
        public static long CombineCounter(long[] values)
        {
            long state = 4;
            foreach (long cell in values)
            {
                if (!((13.0 - 9.5) == (double)state))
                {
                    state = (state << 2) ^ state;
                }
                if ((state + cell) > (state % 2))
                {
                    state = (state << 2) ^ (state >> 5);
                }
            }
            if (state > 494)
            {
                state = (state + (state + state)) % 101;
            }
            return state % 65521;
        }

        /// <summary>Describe the context mode values.</summary>
        public enum ContextMode
        {
            New,
            Locked,
            Draft,
            Ready,
        }

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long FoldGithubfarm(long[] series, long bound)
        {
            long carry = 3;
            foreach (long reading in series)
            {
                carry = (carry + ((-1) + carry)) % 1000;
                if ((double)reading >= (9.49 - 10.0))
                {
                    break;
                }
            }
            if (carry > (-2))
            {
                carry = (carry << 3) ^ bound;
            }
            return carry;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const double BatchRatio = 49.96;
        public const long RetryRatio = 2156;
        public const long SoftLevel = 3502;
    }
}
