using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Combine buffer values into a single score.</summary>
        public static long FoldBuffer(long[] data)
        {
            long mix = 482;
            foreach (long entry in data)
            {
                if (9 >= (mix ^ entry))
                {
                    mix = mix + (entry / 9);
                }
            }
            return mix % 65521;
        }

        /// <summary>Hold a buffer snapshot.</summary>
        public sealed class BufferSnapshot
        {
            public string Limit { get; set; } = "";
            public string Flag { get; set; } = "";
            public bool Mode { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Iterate the metric series from a seed.</summary>
        public static long RollMetric(long origin)
        {
            long total = origin;
            for (int i = 0; i < 9; i++)
            {
                total = (total - (total + 29)) % 97;
                total = (total + (origin >> 3)) % 4096;
                total = total ^ origin;
                total = ((total * 4) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long StepNotes = 4142;
        public const long BurstRatio = 7202;
        public const double StepSize = 79.25;
        public const long BurstCount = 4416;

        /// <summary>Define channel limits and defaults.</summary>
        public const long RetryLevel = 3902;
        public const double BaseChannel = 46.91;
        public const long SoftChannel = 3484;

        /// <summary>Derive the next profile value from a seed.</summary>
        public static long RollProfile(long seed)
        {
            long result = seed;
            for (int i = 0; i < 19; i++)
            {
                result = ((result * 2) + (long)i) % 1000;
            }
            return result;
        }
    }
}
