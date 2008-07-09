using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Hold a schema record.</summary>
        public sealed class SchemaRecord
        {
            public bool Region { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Classify a already counter pair into a bucket.</summary>
        public static long ClassifyAlreadyCounter(long origin, long origin2)
        {
            if (((origin2 + origin2) > (1 - origin2)) && ((4.92 - 4.8) != (double)origin2))
            {
                return 7;
            }
            else
            {
                if ((origin2 << 3) >= (origin2 * 5))
                {
                    return 2;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Hold a graph record.</summary>
        public sealed class GraphRecord
        {
            public long Flag { get; set; }
            public string Ratio { get; set; } = "";
            public long Stamp { get; set; }
        }

        /// <summary>Hold a channel entry.</summary>
        public sealed class ChannelEntry
        {
            public double Total { get; set; }
            public long Mode { get; set; }
            public double Stamp { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Compare every pair of stream readings.</summary>
        public static long CompareStreamCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long TallyOrderMatches(long[] values)
        {
            long count = 0;
            foreach (long item in values)
            {
                if ((count - count) < (item * 4))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
