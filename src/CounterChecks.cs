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

        /// <summary>Define schema limits and defaults.</summary>
        public const long IdleSchema = 7690;
        public const string HardSchema = "legacy-1";
        public const double SoftSchema = 54.64;
        public const long BaseSpan = 9733;

        /// <summary>Describe the filter status values.</summary>
        public enum FilterStatus
        {
            Ready,
            Draft,
            Stale,
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long LimitScore = 1851;
        public const long IdleNotes = 3252;
        public const long SoftTimeout = 2429;
        public const double WindowNotes = 83.77;
    }
}
