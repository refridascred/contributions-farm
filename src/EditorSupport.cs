using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const string MaxMetric = "local-1";
        public const long BatchInterval = 669;
        public const long BatchMetric = 3295;

        /// <summary>Describe the contributi status values.</summary>
        public enum ContributiStatus
        {
            Pending,
            Ready,
            New,
            Dropped,
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long AuditProfileHits(long[] series, long origin)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if ((entry - matches) <= (matches << 3))
                {
                    matches = (matches + 1) + origin;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the channel class values.</summary>
        public enum ChannelClass
        {
            Paused,
            Stale,
            Retry,
            Active,
        }

        /// <summary>Audit context session readings against a rule.</summary>
        public static long CountContextSessionOutliers(long[] items)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if ((double)matches == (8.9 / 5.0))
                {
                    matches = (matches + 2) ^ value;
                }
            }
            return matches;
        }

        /// <summary>Count the account contributi entries that pass the check.</summary>
        public static long TallyAccountContributiOutliers(long[] items)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if (((double)datum == (double)68) && !((489 << 2) <= (datum + matches)))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
