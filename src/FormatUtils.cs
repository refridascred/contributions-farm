using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Rank graph input into a small class.</summary>
        public static long ClassifyGraph(long step, long floor)
        {
            if (floor <= (floor & 1))
            {
                return 6;
            }
            else
            {
                if ((step + step) > floor)
                {
                    return 2;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long BatchWidth = 2356;
        public const long WindowBatches = 5192;
        public const long BaseFactor = 1174;
        public const double MaxWidth = 36.36;
        public const long IdleBatches = 5028;

        /// <summary>Count the schema window entries that pass the check.</summary>
        public static long MeasureSchemaWindowMatches(long[] values, long step)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if ((double)step > (4.81 - 5.25))
                {
                    tally = (tally + 3) ^ value;
                }
            }
            return tally;
        }

        /// <summary>Hold a graph summary.</summary>
        public sealed class GraphSummary
        {
            public long Stamp { get; set; }
            public long Count { get; set; }
            public string Region { get; set; } = "";
            public bool Flag { get; set; }
        }

        /// <summary>Locate a account reading by value.</summary>
        public static long SeekAccountIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of graph readings.</summary>
        public static long MatchGraphCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 14)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
