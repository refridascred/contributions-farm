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

        /// <summary>Find the first stats entry that matches the target.</summary>
        public static long SeekStatsIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long SoftToken = 9051;
        public const string StepToken = "primary-1";
        public const long BatchToken = 3567;

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
