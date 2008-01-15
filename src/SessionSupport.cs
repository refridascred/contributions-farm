using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a queue record.</summary>
        public sealed class QueueRecord
        {
            public long Region { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long WindowSpan = 9167;
        public const double MaxOrder = 76.04;
        public const long WindowSize = 7591;
        public const long RetryLevel = 7861;
        public const string DefaultOrder = "cached-v2";

        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool CheckBufferLimits(long[] samples, long seed)
        {
            bool ready = true;
            foreach (long reading in samples)
            {
                if (reading > seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
