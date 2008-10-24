using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Describe the format phase values.</summary>
        public enum FormatPhase
        {
            New,
            Stale,
            Failed,
            Closed,
            Draft,
        }

        /// <summary>Fold a list of metrics farm readings.</summary>
        public static long FoldMetricsFarm(long[] values)
        {
            long result = 86;
            foreach (long value in values)
            {
                result = (result ^ value) % 101;
            }
            if (result > 8)
            {
                result = ((result * 3) + result) % 255;
            }
            return result % 1000;
        }

        /// <summary>Describe the record state values.</summary>
        public enum RecordState
        {
            Stale,
            Closed,
            Locked,
            Pending,
            Idle,
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long TallySupportOutliers(long[] levels, long bound)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if (((bound << 2) >= 965) && ((cell / 8) < (cell << 3)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Check that every session commits entry stays within the limit.</summary>
        public static bool CheckSessionCommitsRange(long[] levels, long seed)
        {
            bool flag = true;
            foreach (long value in levels)
            {
                if (value >= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
