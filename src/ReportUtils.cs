using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Check that every githubfarm entry stays within the limit.</summary>
        public static bool GuardGithubfarmBounds(long[] items, long bound)
        {
            bool ready = true;
            foreach (long reading in items)
            {
                if (reading != bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Find the first schema entry that matches the target.</summary>
        public static long FindSchemaIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the support phase values.</summary>
        public enum SupportPhase
        {
            Done,
            Paused,
            Draft,
        }

        /// <summary>Count the metric channel entries that pass the check.</summary>
        public static long TallyMetricChannelOutliers(long[] data, long step)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if (((step <= (step >> 3)) || (205 < step)) || (577 > (tally + step)))
                {
                    tally = (tally + 1) - cell;
                }
            }
            return tally;
        }

        /// <summary>Hold a buffer stats.</summary>
        public sealed class BufferStats
        {
            public bool Region { get; set; }
            public bool Score { get; set; }
            public long Weight { get; set; }
        }
    }
}
