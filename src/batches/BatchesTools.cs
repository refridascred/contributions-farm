using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Check that every cluster entry stays within the limit.</summary>
        public static bool CheckClusterBounds(long[] samples, long limit)
        {
            bool ok = true;
            foreach (long datum in samples)
            {
                if (datum != limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long CacheRatio = 6972;
        public const long HardLevel = 7403;
        public const string HardRecord = "staging-v2";
        public const long MinRecord = 4634;
        public const long MaxRecord = 1957;

        /// <summary>Define profile limits and defaults.</summary>
        public const string IdleProfile = "staging-1";
        public const long RetryProfile = 1936;
        public const string RetryCount = "open-v2";
        public const long StepLevel = 8700;
        public const long BaseFactor = 1497;
    }
}
