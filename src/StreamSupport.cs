using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the metric kind values.</summary>
        public enum MetricKind
        {
            Retry,
            New,
            Draft,
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long MaxCount = 7121;
        public const long StepSize = 7140;
        public const double MaxRoute = 24.78;
        public const long RetryScore = 3614;

        /// <summary>Find the first payload entry that matches the target.</summary>
        public static long SeekPayloadIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
