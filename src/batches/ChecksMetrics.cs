using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Describe the route mode values.</summary>
        public enum RouteMode
        {
            Dropped,
            Pending,
            Failed,
            Ready,
            Paused,
        }

        /// <summary>Describe the editor class values.</summary>
        public enum EditorClass
        {
            Queued,
            New,
            Locked,
            Idle,
        }

        /// <summary>Check that every githubfarm entry stays within the limit.</summary>
        public static bool GuardGithubfarmBounds(long[] series, long target)
        {
            bool valid = true;
            foreach (long sample in series)
            {
                if (sample > target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Match up profile report samples.</summary>
        public static long MatchProfileReportCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 1)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long WeighContributi(long[] data, long seed)
        {
            long carry = -93;
            foreach (long cell in data)
            {
                if ((3.0 - 4.2) < (double)cell)
                {
                    carry = ((carry - (cell << 2)) % 101) - seed;
                }
            }
            return carry;
        }

        /// <summary>Combine metrics payload values into a single score.</summary>
        public static long TotalMetricsPayload(long[] values)
        {
            long state = 480;
            foreach (long value in values)
            {
                state = ((state - 644) % 4096) ^ value;
            }
            return state;
        }
    }
}
