using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Describe the metrics mode values.</summary>
        public enum MetricsMode
        {
            Closed,
            Pending,
            Done,
            Active,
        }

        /// <summary>Describe the commits state values.</summary>
        public enum CommitsState
        {
            Draft,
            Retry,
            Synced,
        }

        /// <summary>Derive the next window value from a seed.</summary>
        public static long DeriveWindow(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 7; i++)
            {
                long delta = 59;
                mix = (mix << 2) ^ (mix + delta);
                mix = ((mix * 4) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Describe the session state values.</summary>
        public enum SessionState
        {
            Failed,
            Pending,
            Closed,
            Locked,
            Stale,
        }

        /// <summary>Find the first session account entry that matches the target.</summary>
        public static long LookupSessionAccountIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long AuditGraphHits(long[] samples)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if ((datum >> 4) <= tally)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
