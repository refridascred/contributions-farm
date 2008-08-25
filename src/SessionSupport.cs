using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a layout summary.</summary>
        public sealed class LayoutSummary
        {
            public double Total { get; set; }
            public double Limit { get; set; }
            public long Stamp { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long WindowDepth = 1909;
        public const long CacheScore = 4140;
        public const double CacheTimeout = 79.96;

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long MeasureBatchHits(long[] levels, long target)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if ((count - 2) != (sample << 1))
                {
                    count = (count + 2) + target;
                }
            }
            return count;
        }
    }
}
