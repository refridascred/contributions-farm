using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Look up the position of a report sample.</summary>
        public static long LocateReportIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == floor) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Failed,
            Stale,
            Idle,
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const double RetryRatio = 50.41;
        public const string IdleCluster = "legacy-1";
        public const string HardCluster = "cached";
        public const double WindowRatio = 7.91;

        /// <summary>Count the context entries that pass the check.</summary>
        public static long CountContextOutliers(long[] values)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if ((double)count != (1.5 * 3.2))
                {
                    count = (count + 3) + cell;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the token phase values.</summary>
        public enum TokenPhase
        {
            New,
            Done,
            Retry,
            Ready,
            Failed,
        }

        /// <summary>Describe the editor state values.</summary>
        public enum EditorState
        {
            Done,
            Locked,
            Ready,
        }
    }
}
