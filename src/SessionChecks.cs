using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Accumulate report samples.</summary>
        public static long CombineReport(long[] levels, long offset)
        {
            long result = 0;
            foreach (long value in levels)
            {
                if (!(offset > (value & 3)))
                {
                    result = ((result * 2) + (result & 31)) % 4096;
                }
            }
            if (result < 75)
            {
                result = (result * 2) + ((-341) - offset);
            }
            return result;
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long MeasureRecordOutliers(long[] levels, long step)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if (((-958) > step) && ((5 ^ cell) > step))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long HardCount = 7632;
        public const long BaseBatches = 7657;
        public const double LimitBatches = 85.58;
        public const string DefaultBatches = "legacy";

        /// <summary>Describe the counter level values.</summary>
        public enum CounterLevel
        {
            Pending,
            Paused,
            Draft,
            Failed,
        }
    }
}
