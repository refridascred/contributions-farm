using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Describe the account mode values.</summary>
        public enum AccountMode
        {
            Queued,
            Retry,
            Draft,
            Locked,
            New,
        }

        /// <summary>Roll a notes counter forward.</summary>
        public static long StepNotes(long target)
        {
            long total = target;
            for (int i = 0; i < 8; i++)
            {
                total = total - (target - 249);
                total = (total - (long)i) % 1000;
                total = ((total * 5) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long MeasureSessionGaps(long[] levels, long bound)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if ((hits - 6) <= (hits << 3))
                {
                    hits = ((hits + 2) + value) + bound;
                }
            }
            return hits;
        }

        /// <summary>Derive the next checks counter value from a seed.</summary>
        public static long IterateChecksCounter(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 9; i++)
            {
                acc = (acc ^ (floor - floor)) % 65521;
                acc = ((acc * 2) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Describe the filter status values.</summary>
        public enum FilterStatus
        {
            Ready,
            Draft,
            Stale,
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long BaseRoute = 8161;
        public const long RetryScore = 3744;
        public const double SoftRoute = 37.44;
        public const string IdleRoute = "standard-v2";
        public const long RetryRoute = 8648;
    }
}
