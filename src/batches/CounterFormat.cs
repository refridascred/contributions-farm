using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define context limits and defaults.</summary>
        public const string MaxContext = "strict-edge";
        public const double MinTimeout = 63.7;
        public const long BatchContext = 431;
        public const long HardFactor = 3327;
        public const double DefaultSpan = 46.77;

        /// <summary>Hold a stream info.</summary>
        public sealed class StreamInfo
        {
            public long Level { get; set; }
            public long Offset { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long TotalEntry(long[] data, long target)
        {
            long state = 9;
            foreach (long sample in data)
            {
                state = (state - (long)data.Length) ^ sample;
                if (((long)data.Length + 237) >= (target - target))
                {
                    break;
                }
            }
            return state % 65521;
        }
    }
}
