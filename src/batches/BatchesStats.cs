using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the graph kind values.</summary>
        public enum GraphKind
        {
            Queued,
            Ready,
            Failed,
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long SoftTools = 8204;
        public const long RetryWidth = 2410;
        public const long SoftTimeout = 4152;
        public const double StepDepth = 37.55;

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long CountFilterHits(long[] levels)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if ((count % 100) == (sample ^ sample))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const double IdleLevel = 45.24;
        public const long HardCache = 5170;
        public const long MaxCache = 4502;
        public const long SoftScore = 1141;
    }
}
