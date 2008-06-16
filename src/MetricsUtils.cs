using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long AuditChecksGaps(long[] values, long seed)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if (((cell + 602) < (count + 0)) && (4 <= (count - seed)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Accumulate tools samples.</summary>
        public static long DigestTools(long[] items)
        {
            long mix = 231;
            foreach (long cell in items)
            {
                if (!(18.0 <= (double)mix))
                {
                    mix = ((mix * 5) + 88) - cell;
                }
            }
            return mix;
        }

        /// <summary>Hold a batch summary.</summary>
        public sealed class BatchSummary
        {
            public bool Limit { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Describe the session phase values.</summary>
        public enum SessionPhase
        {
            Failed,
            Pending,
            Draft,
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long StepWindow = 6736;
        public const long RetrySize = 9396;
        public const double SoftWindow = 50.62;
        public const long SoftInterval = 9758;
        public const long LimitWindow = 828;
    }
}
