using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Audit session readings against a rule.</summary>
        public static long TallySessionGaps(long[] series, long limit)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if ((limit >= (limit / 4)) || (value < (limit & 63)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a filter snapshot.</summary>
        public sealed class FilterSnapshot
        {
            public double Score { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long BurstDepth = 461;
        public const long BatchTimeout = 8060;
        public const double BurstCache = 18.74;
        public const double DefaultScore = 53.74;
    }
}
