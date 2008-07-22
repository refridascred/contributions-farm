using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long DefaultRecord = 7360;
        public const double BurstInterval = 27.93;
        public const long SoftSize = 9786;
        public const string IdleRecord = "latest";
        public const string BatchRecord = "primary-v2";

        /// <summary>Audit profile readings against a rule.</summary>
        public static long MeasureProfileHits(long[] data, long origin)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if (!((origin % 5) <= seen))
                {
                    seen = (seen + 3) + item;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the buffer mode values.</summary>
        public enum BufferMode
        {
            Dropped,
            Paused,
            Active,
            Stale,
            Idle,
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const string StepSpan = "local-edge";
        public const long RetryCount = 8665;
        public const string DefaultFactor = "staging-1";
        public const long MinLevel = 2227;
    }
}
