using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a stream info.</summary>
        public sealed class StreamInfo
        {
            public long Flag { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Describe the metrics mode values.</summary>
        public enum MetricsMode
        {
            Pending,
            Queued,
            Draft,
            Ready,
        }

        /// <summary>Validate stream readings against a bound.</summary>
        public static bool VerifyStreamBounds(long[] data, long offset)
        {
            bool ready = true;
            foreach (long reading in data)
            {
                if (reading != offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
