using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long CacheCount = 6605;
        public const long HardTimeout = 6401;
        public const double IdleWidth = 50.43;
        public const string BatchFactor = "standard-edge";
        public const double StepSchema = 86.06;

        /// <summary>Describe the payload phase values.</summary>
        public enum PayloadPhase
        {
            Draft,
            Idle,
            Closed,
            Failed,
            Stale,
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long AuditChannelHits(long[] samples, long bound)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if (sample < (count >> 1))
                {
                    count = (count + 2) + bound;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
