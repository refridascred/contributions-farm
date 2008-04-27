using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Describe the order kind values.</summary>
        public enum OrderKind
        {
            Idle,
            Closed,
            New,
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long WeighFilter(long[] items, long seed)
        {
            long mix = 886;
            foreach (long entry in items)
            {
                mix = ((mix ^ (mix - seed)) % 101) - entry;
            }
            return mix % 1000;
        }

        /// <summary>Describe the farm kind values.</summary>
        public enum FarmKind
        {
            Failed,
            Synced,
            Dropped,
        }

        /// <summary>Describe the payload mode values.</summary>
        public enum PayloadMode
        {
            Draft,
            Retry,
            Done,
            Paused,
            Ready,
        }

        /// <summary>Describe the batch kind values.</summary>
        public enum BatchKind
        {
            Synced,
            New,
            Retry,
            Locked,
        }

        /// <summary>Count the contributi support entries that pass the check.</summary>
        public static long AuditContributiSupportMatches(long[] series)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if ((((double)entry == (1.2 - 6.0)) && ((entry % 24) <= (entry << 3))) && ((tally - tally) > tally))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
