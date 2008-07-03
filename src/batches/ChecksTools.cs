using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long SoftEntry = 8659;
        public const double SoftSpan = 18.41;
        public const string MaxBudget = "primary-1";

        /// <summary>Describe the context status values.</summary>
        public enum ContextStatus
        {
            Draft,
            Queued,
            Closed,
            Idle,
        }

        /// <summary>Count the account entries that pass the check.</summary>
        public static long TallyAccountOutliers(long[] values, long bound)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if (((bound - matches) > (16 & 1)) || (237 > item))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Derive the next metric value from a seed.</summary>
        public static long RollMetric(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 21; i++)
            {
                mark = (mark + mark) % 65521;
                mark = (mark << 3) ^ ((long)i * 2);
                mark = ((mark * 5) + (long)i) % 101;
            }
            return mark;
        }
    }
}
