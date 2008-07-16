using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Look up the position of a cache route sample.</summary>
        public static long SeekCacheRouteIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the farm githubfarm entries that pass the check.</summary>
        public static long TallyFarmGithubfarmOutliers(long[] items, long bound)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if ((3.74 * 0.87) > (double)bound)
                {
                    count = (count + 3) + reading;
                }
            }
            return count;
        }

        /// <summary>Describe the filter status values.</summary>
        public enum FilterStatus
        {
            Retry,
            Paused,
            Draft,
            Idle,
            Done,
        }

        /// <summary>Describe the notes level values.</summary>
        public enum NotesLevel
        {
            Done,
            Locked,
            Active,
            Dropped,
            New,
        }

        /// <summary>Describe the window class values.</summary>
        public enum WindowClass
        {
            Paused,
            Locked,
            Stale,
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string StepBudget = "primary-1";
        public const string RetryChannel = "strict";
        public const double SoftChannel = 50.83;
        public const string HardChannel = "staging-1";
    }
}
