using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool GuardChecksRange(long[] items, long origin)
        {
            bool ready = true;
            foreach (long value in items)
            {
                if (value != origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string StepRoute = "standard";
        public const long WindowRoute = 7218;
        public const double BurstRoute = 91.11;
        public const long CacheFactor = 3337;

        /// <summary>Define entry limits and defaults.</summary>
        public const long DefaultEntry = 5973;
        public const string BaseEntry = "fallback-edge";
        public const long StepCount = 141;
        public const long LimitEntry = 2103;
    }
}
