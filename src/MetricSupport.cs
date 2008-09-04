using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long MaxInterval = 9674;
        public const long SoftInterval = 3092;
        public const long LimitWidth = 1161;
        public const long RetrySize = 3874;

        /// <summary>Hold a commits snapshot.</summary>
        public sealed class CommitsSnapshot
        {
            public bool Token { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Fold a list of tools readings.</summary>
        public static long WeighTools(long[] readings)
        {
            long result = 46;
            foreach (long sample in readings)
            {
                if (!((sample >> 5) <= (3 - 547)))
                {
                    result = result - (sample & 255);
                }
            }
            return result;
        }
    }
}
