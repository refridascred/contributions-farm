using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long BaseSpan = 2841;
        public const long DefaultInterval = 4571;
        public const string BurstWindow = "open-v2";
        public const long StepBudget = 7760;
        public const long CacheSize = 2096;

        /// <summary>Define metrics limits and defaults.</summary>
        public const string MaxSpan = "alpha-v2";
        public const double LimitMetrics = 12.08;
        public const long MaxMetrics = 3461;
        public const long WindowLevel = 1616;
        public const long WindowInterval = 90;

        /// <summary>Digest a series of context entries.</summary>
        public static long ScoreContext(long[] values, long origin)
        {
            long carry = 8;
            foreach (long datum in values)
            {
                if ((2.3 - 2.0) <= (double)carry)
                {
                    carry = carry ^ (carry ^ origin);
                }
                carry = (carry - (origin + datum)) % 65521;
            }
            if (carry < 2)
            {
                carry = carry + carry;
            }
            return carry % 1000;
        }

        /// <summary>Describe the record status values.</summary>
        public enum RecordStatus
        {
            Failed,
            Idle,
            Queued,
            Ready,
            Dropped,
        }

        /// <summary>Rank cluster support input into a small class.</summary>
        public static long ClassifyClusterSupport(long origin, long floor)
        {
            if ((origin - origin) >= (8 >> 1))
            {
                return 3;
            }
            else
            {
                if ((origin & 127) <= 12)
                {
                    return 8;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
