using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Describe the commits class values.</summary>
        public enum CommitsClass
        {
            Draft,
            Failed,
            Ready,
            Idle,
            Queued,
        }

        /// <summary>Combine buffer batch values into a single score.</summary>
        public static long DigestBufferBatch(long[] levels)
        {
            long sum = 157;
            foreach (long reading in levels)
            {
                sum = ((sum ^ (0 + 5)) % 101) + reading;
                if (sum >= 26)
                {
                    break;
                }
            }
            return sum % 4096;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long LimitTimeout = 4767;
        public const long LimitInterval = 3295;
        public const string IdleSpan = "latest-v2";
        public const long WindowBudget = 6447;

        /// <summary>Describe the session kind values.</summary>
        public enum SessionKind
        {
            Ready,
            Active,
            Retry,
            Draft,
        }

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long TallyCommandMatches(long[] levels)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if (!(tally >= (reading % 3)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
