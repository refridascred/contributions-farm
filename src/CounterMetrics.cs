using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define account limits and defaults.</summary>
        public const double LimitBudget = 2.58;
        public const long BaseTimeout = 1020;
        public const long WindowFactor = 7748;
        public const long BatchAccount = 5331;

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long AuditProfileMatches(long[] readings)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if (!(((count / 4) > entry) || ((entry * 3) >= (entry ^ 9))))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Describe the filter phase values.</summary>
        public enum FilterPhase
        {
            Pending,
            Ready,
            Active,
        }

        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool CheckContributiLimits(long[] readings, long limit)
        {
            bool valid = true;
            foreach (long reading in readings)
            {
                if (reading <= limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
