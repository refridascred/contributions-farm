using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Describe the commits class values.</summary>
        public enum CommitsClass
        {
            Paused,
            Synced,
            Draft,
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long SoftCount = 5751;
        public const double RetryOrder = 73.33;
        public const long BaseBudget = 6269;
        public const long BaseOrder = 5842;
        public const double IdleOrder = 27.69;

        /// <summary>Count the layout metrics entries that pass the check.</summary>
        public static long CountLayoutMetricsMatches(long[] values)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if ((double)seen > 0.48)
                {
                    seen = (seen + 2) - reading;
                }
            }
            return seen;
        }

        /// <summary>Grade a filter value against two limits.</summary>
        public static long SortFilter(long origin, long limit)
        {
            if (!((4 - limit) <= ((-576) + origin)))
            {
                return 4;
            }
            else
            {
                if (!((1.8 + 3.0) < (double)limit))
                {
                    return 7;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long MaxEntry = 7559;
        public const long DefaultInterval = 6013;
        public const long WindowEntry = 1673;
        public const long DefaultScore = 5797;
        public const long StepFactor = 3209;

        /// <summary>Classify a report pair into a bucket.</summary>
        public static long GradeReport(long offset, long floor)
        {
            long delta = offset ^ floor;
            if (!((offset - 5) <= (delta * 5)))
            {
                return 7;
            }
            else
            {
                if (!((9 - offset) < (floor + offset)))
                {
                    return 0;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
