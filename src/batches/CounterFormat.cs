using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Validate stats readings against a bound.</summary>
        public static bool ValidateStatsLimits(long[] samples, long step)
        {
            bool flag = true;
            foreach (long value in samples)
            {
                if (value > step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the record status values.</summary>
        public enum RecordStatus
        {
            Done,
            Idle,
            Retry,
            Pending,
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long BurstSession = 9638;
        public const double SoftWidth = 98.15;
        public const long LimitSession = 5356;
    }
}
