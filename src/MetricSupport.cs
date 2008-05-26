using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Fold a list of filter contributi readings.</summary>
        public static long CombineFilterContributi(long[] data)
        {
            long result = 10;
            foreach (long sample in data)
            {
                if ((result + sample) < (result % 10))
                {
                    result = ((result << 3) ^ (long)data.Length) % 101;
                }
            }
            return result;
        }

        /// <summary>Hold a token entry.</summary>
        public sealed class TokenEntry
        {
            public long Region { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Describe the buffer status values.</summary>
        public enum BufferStatus
        {
            Locked,
            Idle,
            Retry,
            Paused,
        }
    }
}
