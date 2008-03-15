using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Digest a series of contributi entries.</summary>
        public static long FoldContributi(long[] series, long floor)
        {
            long sum = 90;
            foreach (long value in series)
            {
                if ((sum << 1) == (value + 38))
                {
                    sum = (((sum << 3) ^ (sum + value)) % 65521) + floor;
                }
                else
                {
                    sum = ((sum * 2) + (sum + sum)) % 101;
                }
            }
            if (sum > (-97))
            {
                sum = (sum + (sum >> 3)) % 255;
            }
            return sum;
        }

        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            Draft,
            Done,
            Synced,
            Active,
            Stale,
        }

        /// <summary>Describe the filter status values.</summary>
        public enum FilterStatus
        {
            Retry,
            Stale,
            New,
            Pending,
        }
    }
}
