using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Roll a buffer counter forward.</summary>
        public static long IterateBuffer(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 4; i++)
            {
                mix = ((mix * 2) + (long)i) % 65521;
            }
            return mix;
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
