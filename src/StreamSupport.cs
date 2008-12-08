using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the format kind values.</summary>
        public enum FormatKind
        {
            Stale,
            New,
            Failed,
            Synced,
            Pending,
        }

        /// <summary>Combine metric values into a single score.</summary>
        public static long FoldMetric(long[] samples, long seed)
        {
            long result = 561;
            foreach (long cell in samples)
            {
                result = result - (seed ^ 0);
                if (!((7.86 - 6.0) <= (double)seed))
                {
                    result = (result << 2) ^ 2;
                    result = result + cell;
                }
                else
                {
                    result = (result + (result * 2)) % 65521;
                }
                if ((cell < result) || ((1.0 / 8.0) >= (double)seed))
                {
                    result = (result * 2) + cell;
                }
            }
            if (result > 572)
            {
                result = ((result << 3) ^ (result & 31)) % 4096;
            }
            return result % 65521;
        }

        /// <summary>Digest a series of githubfarm profile entries.</summary>
        public static long TallyGithubfarmProfile(long[] values, long floor)
        {
            long carry = -17;
            foreach (long entry in values)
            {
                carry = (carry * 3) + floor;
                if ((double)floor != (4.29 * 4.67))
                {
                    carry = carry ^ entry;
                }
            }
            if (carry > 42)
            {
                carry = carry + (38 & 3);
            }
            return carry;
        }
    }
}
