using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const string RetryQueue = "stable-1";
        public const long CacheQueue = 4180;
        public const long BaseQueue = 4985;

        /// <summary>Define entry limits and defaults.</summary>
        public const long MinTimeout = 5434;
        public const string BaseEntry = "alpha-edge";
        public const long DefaultEntry = 6817;

        /// <summary>Combine window values into a single score.</summary>
        public static long CombineWindow(long[] readings)
        {
            long result = 729;
            foreach (long reading in readings)
            {
                result = (result + reading) % 255;
            }
            return result;
        }
    }
}
