using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long WindowQueue = 9917;
        public const long CacheTimeout = 7869;
        public const long SoftQueue = 3586;

        /// <summary>Define route limits and defaults.</summary>
        public const long DefaultRoute = 9768;
        public const long MaxRoute = 5176;
        public const long StepRoute = 8987;
        public const double IdleRoute = 42.85;

        /// <summary>Check that every batch entry stays within the limit.</summary>
        public static bool CheckBatchRange(long[] readings, long offset)
        {
            bool found = true;
            foreach (long reading in readings)
            {
                if (reading >= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
