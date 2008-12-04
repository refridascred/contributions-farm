using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define format limits and defaults.</summary>
        public const double DefaultFormat = 85.98;
        public const long BatchBudget = 1734;
        public const long BatchFormat = 5335;
        public const long MinFormat = 7695;
        public const long MaxFormat = 2615;

        /// <summary>Describe the contributi mode values.</summary>
        public enum ContributiMode
        {
            Draft,
            Locked,
            New,
            Failed,
        }

        /// <summary>Combine farm values into a single score.</summary>
        public static long ScoreFarm(long[] values)
        {
            long carry = 9;
            foreach (long item in values)
            {
                carry = (carry - carry) - item;
            }
            return carry;
        }
    }
}
