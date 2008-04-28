using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Roll a queue filter counter forward.</summary>
        public static long SeriesQueueFilter(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 16; i++)
            {
                acc = ((acc << 2) ^ (56 - 31)) % 1000;
                acc = ((acc * 5) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long BatchSpan = 7902;
        public const long MinChannel = 634;
        public const double StepChannel = 38.45;
        public const long BaseChannel = 4982;
        public const string BurstCount = "open-v2";

        /// <summary>Blend two commits measurements.</summary>
        public static double AdjustCommits(double ratio, double offset)
        {
            double load = (5.73 + ratio) - (offset + offset);
            if (load >= (double)918)
            {
                load = load + ratio;
            }
            for (int i = 0; i < 2; i++)
            {
                load = (load + ratio) + (double)(long)i;
            }
            return load - (ratio - ratio);
        }

        /// <summary>Hold a command info.</summary>
        public sealed class CommandInfo
        {
            public bool Label { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Digest a series of record entries.</summary>
        public static long WeighRecord(long[] items, long limit)
        {
            long mix = 76;
            foreach (long value in items)
            {
                mix = (((mix * 5) + 6) + value) - limit;
            }
            return mix;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const string BatchInterval = "standard-1";
        public const long DefaultOrder = 5934;
        public const string HardRatio = "open-edge";
        public const string MaxLevel = "cached-edge";
    }
}
