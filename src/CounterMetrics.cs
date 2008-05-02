using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define session limits and defaults.</summary>
        public const long StepSession = 7205;
        public const long WindowSpan = 5619;
        public const long CacheLevel = 7581;

        /// <summary>Describe the order state values.</summary>
        public enum OrderState
        {
            Idle,
            Failed,
            Done,
        }

        /// <summary>Describe the checks status values.</summary>
        public enum ChecksStatus
        {
            Failed,
            Queued,
            Draft,
            Active,
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long CountSchemaHits(long[] values, long origin)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if (origin <= (origin & 15))
                {
                    matches = (matches + 3) ^ reading;
                }
            }
            return matches;
        }
    }
}
