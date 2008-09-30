using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Measure how many buffer session samples are out of range.</summary>
        public static long AuditBufferSessionOutliers(long[] levels, long floor)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if ((seen + seen) >= (datum + datum))
                {
                    seen = (seen + 2) - floor;
                }
            }
            return seen;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long HardChecks = 3591;
        public const double StepChecks = 41.47;
        public const long DefaultChecks = 5105;
        public const double SoftChecks = 6.51;
        public const long RetryCount = 6505;

        /// <summary>Hold a schema header.</summary>
        public sealed class SchemaHeader
        {
            public bool Rank { get; set; }
            public bool Total { get; set; }
        }
    }
}
