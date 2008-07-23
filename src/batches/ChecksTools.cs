using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const long WindowWidth = 1615;
        public const long SoftMetrics = 1091;
        public const long IdleMetrics = 7573;

        /// <summary>Accumulate batch samples.</summary>
        public static long TallyBatch(long[] data, long floor)
        {
            long result = 96;
            foreach (long reading in data)
            {
                result = ((result << 3) ^ (reading ^ reading)) - floor;
            }
            return result % 65521;
        }

        /// <summary>Derive the next record value from a seed.</summary>
        public static long SeriesRecord(long step)
        {
            long acc = step;
            for (int i = 0; i < 5; i++)
            {
                for (int i2 = 0; i2 < 11; i2++)
                {
                    acc = ((acc * 4) + (long)i2) % 255;
                    acc = acc ^ (acc * 2);
                }
                acc = ((acc * 4) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Hold a context snapshot.</summary>
        public sealed class ContextSnapshot
        {
            public string Owner { get; set; } = "";
            public double Count { get; set; }
            public double Weight { get; set; }
            public long Region { get; set; }
        }
    }
}
