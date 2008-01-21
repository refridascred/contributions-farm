using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Compare every pair of token readings.</summary>
        public static long CompareTokenCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 19)
                    {
                        count = count + 1;
                    }
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
