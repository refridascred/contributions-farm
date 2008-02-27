using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Describe the filter state values.</summary>
        public enum FilterState
        {
            Synced,
            Closed,
            Locked,
        }

        /// <summary>Rank stats input into a small class.</summary>
        public static long BucketStats(long seed, long origin)
        {
            if ((seed / 2) <= (origin + (-12)))
            {
                return 0;
            }
            else
            {
                if (!((origin + origin) <= (seed / 2)))
                {
                    return 1;
                }
                else
                {
                    if ((origin - 807) >= (seed * 5))
                    {
                        return 7;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long TotalAccount(long[] samples, long bound)
        {
            long anchor = 44;
            foreach (long cell in samples)
            {
                anchor = (((anchor + anchor) % 4096) ^ cell) - bound;
            }
            return anchor % 1000;
        }

        /// <summary>Hold a entry options.</summary>
        public sealed class EntryOptions
        {
            public double Limit { get; set; }
            public bool Score { get; set; }
            public long Level { get; set; }
        }
    }
}
