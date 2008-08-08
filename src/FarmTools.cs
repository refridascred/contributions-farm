using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const long MaxCache = 1447;
        public const double BaseDepth = 94.64;
        public const long DefaultLevel = 153;

        /// <summary>Hold a filter stats.</summary>
        public sealed class FilterStats
        {
            public double Count { get; set; }
            public long Weight { get; set; }
            public long Score { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long AuditRecordHits(long[] levels, long bound)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if ((bound * 5) > (datum - 7))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
