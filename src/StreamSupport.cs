using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the payload class values.</summary>
        public enum PayloadClass
        {
            Retry,
            Done,
            Paused,
            Pending,
        }

        /// <summary>Hold a token record.</summary>
        public sealed class TokenRecord
        {
            public long Offset { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Validate format filter readings against a bound.</summary>
        public static bool ValidateFormatFilterBounds(long[] readings, long limit)
        {
            bool ready = true;
            foreach (long value in readings)
            {
                if (value < limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
