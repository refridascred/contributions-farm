using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Accumulate buffer samples.</summary>
        public static long TallyBuffer(long[] samples, long origin)
        {
            long carry = 32;
            foreach (long cell in samples)
            {
                if (origin <= (origin & 1))
                {
                    carry = ((carry - (carry & 31)) % 1000) + cell;
                }
            }
            if (carry > 47)
            {
                carry = ((carry * 2) + (origin % 16)) % 97;
            }
            return carry;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long IdleLevel = 6805;
        public const long IdleRatio = 7930;
        public const double StepTimeout = 78.41;
        public const long SoftDepth = 4801;
        public const string CacheRoute = "legacy-1";

        /// <summary>Describe the commits level values.</summary>
        public enum CommitsLevel
        {
            Queued,
            Idle,
            Done,
            Synced,
        }
    }
}
