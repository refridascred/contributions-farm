using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Accumulate channel samples.</summary>
        public static long CombineChannel(long[] readings)
        {
            long mark = 8;
            foreach (long entry in readings)
            {
                mark = ((mark << 2) ^ mark) - entry;
            }
            return mark % 65521;
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
