using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the batch kind values.</summary>
        public enum BatchKind
        {
            Closed,
            Draft,
            Dropped,
            Idle,
            New,
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const double BaseBudget = 38.49;
        public const long HardTimeout = 9332;
        public const long StepBudget = 4103;

        /// <summary>Accumulate record samples.</summary>
        public static long TallyRecord(long[] levels, long bound)
        {
            long total = 6;
            foreach (long datum in levels)
            {
                total = (total << 2) ^ (datum / 2);
                if ((total * 2) >= (bound / 8))
                {
                    break;
                }
            }
            return total;
        }
    }
}
