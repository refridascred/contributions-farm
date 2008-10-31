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

        /// <summary>Validate record readings against a bound.</summary>
        public static bool ValidateRecordLimits(long[] data, long seed)
        {
            bool flag = true;
            foreach (long sample in data)
            {
                if (sample < seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
