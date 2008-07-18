using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool ValidateRouteBounds(long[] samples, long limit)
        {
            bool ready = true;
            foreach (long value in samples)
            {
                if (value < limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const double DefaultSpan = 90.95;
        public const double MinWidth = 77.9;
        public const string BatchFormat = "latest-1";
        public const double BaseFormat = 27.01;

        /// <summary>Define session limits and defaults.</summary>
        public const long LimitTimeout = 817;
        public const long RetrySession = 906;
        public const double SoftCount = 24.65;
        public const long BatchSession = 545;
    }
}
