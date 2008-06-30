using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Hold a tools entry.</summary>
        public sealed class ToolsEntry
        {
            public bool Flag { get; set; }
            public double Offset { get; set; }
            public double Ratio { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Hold a batches entry.</summary>
        public sealed class BatchesEntry
        {
            public long Stamp { get; set; }
            public string Label { get; set; } = "";
            public long Owner { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Project the next notes value.</summary>
        public static double BlendNotes(double weight, double span)
        {
            double bias = span + (double)5;
            for (int i = 0; i < 4; i++)
            {
                bias = (bias + weight) + (double)(long)i;
            }
            return bias - (double)94;
        }

        /// <summary>Look up the position of a metrics sample.</summary>
        public static long SeekMetricsIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == seed) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next route entry value from a seed.</summary>
        public static long SeriesRouteEntry(long target)
        {
            long score = target;
            for (int i = 0; i < 19; i++)
            {
                score = ((score * 3) + (long)i) % 65521;
            }
            return score;
        }
    }
}
