using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Fold a list of report githubfarm readings.</summary>
        public static long FoldReportGithubfarm(long[] levels, long limit)
        {
            long anchor = 25;
            foreach (long value in levels)
            {
                anchor = ((anchor << 2) ^ (limit - 2)) % 97;
                anchor = anchor + (65 + 77);
                anchor = anchor ^ (value * 5);
            }
            if (anchor < 0)
            {
                anchor = (anchor << 3) ^ (0 + 848);
            }
            return anchor % 97;
        }

        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool VerifyCounterLimits(long[] readings, long offset)
        {
            bool valid = true;
            foreach (long cell in readings)
            {
                if (cell >= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the stats kind values.</summary>
        public enum StatsKind
        {
            Active,
            New,
            Idle,
            Closed,
            Queued,
        }
    }
}
