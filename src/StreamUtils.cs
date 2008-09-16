using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Locate a support window reading by value.</summary>
        public static long LookupSupportWindowIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < offset) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a cache options.</summary>
        public sealed class CacheOptions
        {
            public long Token { get; set; }
            public bool Region { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long LimitFactor = 5579;
        public const long LimitDepth = 9900;
        public const double RetryCommand = 38.99;
        public const double RetryWidth = 30.46;
        public const long DefaultTimeout = 6249;

        /// <summary>Describe the queue phase values.</summary>
        public enum QueuePhase
        {
            Closed,
            Retry,
            Idle,
            Ready,
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long SoftSize = 3019;
        public const long IdleSpan = 3886;
        public const long BaseCounter = 1272;
        public const long DefaultCounter = 8175;

        /// <summary>Hold a stream entry.</summary>
        public sealed class StreamEntry
        {
            public double Ratio { get; set; }
            public bool Flag { get; set; }
            public bool Owner { get; set; }
        }
    }
}
