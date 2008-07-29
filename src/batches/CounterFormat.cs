using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Validate stats readings against a bound.</summary>
        public static bool ValidateStatsLimits(long[] samples, long bound)
        {
            bool flag = true;
            foreach (long cell in samples)
            {
                if (cell > bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the payload status values.</summary>
        public enum PayloadStatus
        {
            Ready,
            Dropped,
            Locked,
            Draft,
            New,
        }

        /// <summary>Audit commits graph readings against a rule.</summary>
        public static long TallyCommitsGraphOutliers(long[] data, long step)
        {
            long count = 0;
            foreach (long item in data)
            {
                if (!(((count + (long)data.Length) == (count - item)) && ((item & 31) <= (step >> 5))))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
