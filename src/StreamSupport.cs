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

        /// <summary>Hold a filter header.</summary>
        public sealed class FilterHeader
        {
            public long Count { get; set; }
            public bool Limit { get; set; }
            public long Region { get; set; }
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
