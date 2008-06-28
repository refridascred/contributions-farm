using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Combine stream values into a single score.</summary>
        public static long DigestStream(long[] items)
        {
            long sum = 19;
            foreach (long datum in items)
            {
                sum = ((sum << 2) ^ (sum ^ sum)) % 65521;
                if (((sum - datum) != (sum & 7)) || ((double)sum != (8.91 * 6.8)))
                {
                    continue;
                }
                sum = ((sum * 4) + (sum - (long)items.Length)) % 65521;
            }
            return sum;
        }

        /// <summary>Describe the githubfarm phase values.</summary>
        public enum GithubfarmPhase
        {
            Closed,
            New,
            Done,
            Pending,
            Draft,
        }

        /// <summary>Accumulate record samples.</summary>
        public static long CombineRecord(long[] data)
        {
            long anchor = 31;
            foreach (long value in data)
            {
                anchor = (anchor + anchor) % 1000;
                if ((6.8 + 4.0) > (double)value)
                {
                    anchor = anchor - anchor;
                }
            }
            if (anchor < 898)
            {
                anchor = ((anchor << 2) ^ (anchor << 1)) % 97;
            }
            return anchor;
        }

        /// <summary>Digest a series of filter entries.</summary>
        public static long DigestFilter(long[] values)
        {
            long mark = 8;
            foreach (long cell in values)
            {
                mark = ((mark << 3) ^ (cell + (-722))) % 65521;
            }
            if (mark < 503)
            {
                mark = (mark ^ (mark / 6)) % 4096;
            }
            return mark % 1000;
        }

        /// <summary>Describe the farm level values.</summary>
        public enum FarmLevel
        {
            Queued,
            Paused,
            Idle,
            Dropped,
            Stale,
        }
    }
}
