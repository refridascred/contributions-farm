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

        /// <summary>Define profile limits and defaults.</summary>
        public const long DefaultDepth = 7598;
        public const long BaseLevel = 9276;
        public const string StepBudget = "standard-edge";

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
