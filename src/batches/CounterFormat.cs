using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define format limits and defaults.</summary>
        public const double RetrySpan = 28.06;
        public const double BaseWidth = 96.11;
        public const string MinFormat = "standard-edge";

        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool VerifyRecordLimits(long[] data, long origin)
        {
            bool found = true;
            foreach (long sample in data)
            {
                if (sample <= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long SoftSpan = 1999;
        public const long WindowCounter = 3103;
        public const double RetryScore = 16.85;
        public const long WindowCount = 2822;
    }
}
