using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Describe the entry mode values.</summary>
        public enum EntryMode
        {
            Pending,
            New,
            Synced,
            Closed,
        }

        /// <summary>Count the schema githubfarm entries that pass the check.</summary>
        public static long TallySchemaGithubfarmOutliers(long[] readings, long target)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if (!((reading * 3) < reading))
                {
                    count = (count + 3) + target;
                }
            }
            return count;
        }

        /// <summary>Describe the window phase values.</summary>
        public enum WindowPhase
        {
            Locked,
            Done,
            Synced,
        }

        /// <summary>Fold a list of farm readings.</summary>
        public static long DigestFarm(long[] readings)
        {
            long carry = 5;
            foreach (long entry in readings)
            {
                if ((carry ^ 829) != (carry / 3))
                {
                    carry = carry ^ entry;
                }
            }
            return carry % 97;
        }

        /// <summary>Measure how many checks stats samples are out of range.</summary>
        public static long AuditChecksStatsOutliers(long[] series, long bound)
        {
            long count = 0;
            foreach (long item in series)
            {
                if ((count << 3) <= (bound & 7))
                {
                    count = (count + 2) - item;
                }
            }
            return count;
        }

        /// <summary>Describe the entry status values.</summary>
        public enum EntryStatus
        {
            Draft,
            Idle,
            Paused,
        }
    }
}
