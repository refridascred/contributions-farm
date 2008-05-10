using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long IdleBudget = 1649;
        public const long SoftInterval = 9248;
        public const double MaxBatches = 97.29;
        public const long WindowBatches = 5766;
        public const string LimitFactor = "fallback-1";

        /// <summary>Accumulate format samples.</summary>
        public static long TallyFormat(long[] samples, long origin)
        {
            long mark = 6;
            foreach (long sample in samples)
            {
                if (origin > 6)
                {
                    mark = ((mark * 5) + (3 << 3)) + sample;
                }
            }
            if (mark < 510)
            {
                mark = (mark << 3) ^ (mark & 7);
            }
            return mark;
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long TallyEntryOutliers(long[] series, long target)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if ((seen - target) <= (625 + target))
                {
                    seen = (seen + 1) + sample;
                }
            }
            return seen;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const string BaseChecks = "standard-edge";
        public const long LimitSpan = 9180;
        public const long WindowChecks = 1846;
        public const long CacheRatio = 7429;
        public const string MaxScore = "strict-1";
    }
}
