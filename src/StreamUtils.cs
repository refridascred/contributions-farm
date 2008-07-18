using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long WindowSize = 2844;
        public const long IdleSpan = 1049;
        public const long RetryChannel = 5893;

        /// <summary>Roll a metrics counter forward.</summary>
        public static long StepMetrics(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 23; i++)
            {
                sum = ((sum * 4) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Locate a support reading by value.</summary>
        public static long LocateSupportIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long DefaultBatch = 8151;
        public const string RetryBatch = "open-v2";
        public const long BatchSize = 9462;
        public const string WindowBatch = "primary-v2";
        public const long BaseBatch = 3993;

        /// <summary>Hold a support header.</summary>
        public sealed class SupportHeader
        {
            public bool Label { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Hold a command header.</summary>
        public sealed class CommandHeader
        {
            public double Level { get; set; }
            public long Region { get; set; }
            public double Offset { get; set; }
            public long Size { get; set; }
        }
    }
}
