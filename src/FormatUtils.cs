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

        /// <summary>Combine profile values into a single score.</summary>
        public static long TallyProfile(long[] levels, long step)
        {
            long result = 6;
            foreach (long sample in levels)
            {
                result = (result ^ (result + sample)) - step;
            }
            if (result > 319)
            {
                result = result ^ (result ^ 9);
            }
            return result;
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
