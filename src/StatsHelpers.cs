using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long BurstInterval = 2553;
        public const long CacheSchema = 6926;
        public const string MaxWidth = "standard-v2";
        public const long BurstSchema = 2974;
        public const double RetryWidth = 82.89;

        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool GuardEntryBounds(long[] values, long bound)
        {
            bool ready = true;
            foreach (long reading in values)
            {
                if (reading <= bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Match up checks batch samples.</summary>
        public static long MatchChecksBatchCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Count the window session entries that pass the check.</summary>
        public static long TallyWindowSessionOutliers(long[] series)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if (value < (tally * 2))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the editor level values.</summary>
        public enum EditorLevel
        {
            Draft,
            Idle,
            Closed,
            Synced,
            Dropped,
        }
    }
}
