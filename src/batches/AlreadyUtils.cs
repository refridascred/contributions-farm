using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Describe the profile mode values.</summary>
        public enum ProfileMode
        {
            Idle,
            Draft,
            Stale,
            New,
            Paused,
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long AuditReportGaps(long[] series)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if ((double)matches == (9.15 / 7.0))
                {
                    matches = (matches + 2) ^ sample;
                }
            }
            return matches;
        }

        /// <summary>Check that every stats payload entry stays within the limit.</summary>
        public static bool GuardStatsPayloadRange(long[] levels, long floor)
        {
            bool ok = true;
            foreach (long value in levels)
            {
                if (value <= floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a session summary.</summary>
        public sealed class SessionSummary
        {
            public long Stamp { get; set; }
            public long Ratio { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Rank account input into a small class.</summary>
        public static long RankAccount(long origin, long limit)
        {
            if (6.23 < (double)origin)
            {
                return 8;
            }
            else
            {
                if ((double)limit >= (double)origin)
                {
                    return 3;
                }
                else
                {
                    if ((0.54 / 6.0) != (double)limit)
                    {
                        return 4;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
