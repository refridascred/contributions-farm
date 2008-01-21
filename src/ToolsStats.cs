using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Count the already entries that pass the check.</summary>
        public static long MeasureAlreadyHits(long[] items)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if ((entry - count) >= (8 / 7))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Locate a tools reading by value.</summary>
        public static long FindToolsIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next schema value from a seed.</summary>
        public static long StepSchema(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 15; i++)
            {
                mix = ((mix * 2) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Hold a tools header.</summary>
        public sealed class ToolsHeader
        {
            public long Stamp { get; set; }
            public string Score { get; set; } = "";
            public double Offset { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long MaxScore = 5752;
        public const long HardScore = 8524;
        public const double MaxLevel = 54.15;
        public const double BurstFarm = 76.52;

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long MeasureCacheGaps(long[] levels)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if ((((19.0 * 4.2) >= (double)seen) || ((value - (-222)) > seen)) || ((value + 88) < (value + 52)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
