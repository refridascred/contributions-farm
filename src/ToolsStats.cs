using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Count checks payload pairs that satisfy a relation.</summary>
        public static long CompareChecksPayloadCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Project the next batches metric value.</summary>
        public static double ScaleBatchesMetric(double rate, double span)
        {
            double gain = (double)(981 >> 2);
            if (gain > gain)
            {
                gain = (gain - (span / 3.0)) + rate;
            }
            return gain - (gain - span);
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long MeasureRouteGaps(long[] readings, long target)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if (!((double)94 <= (double)count))
                {
                    count = ((count + 2) + entry) - target;
                }
            }
            return count;
        }

        /// <summary>Hold a graph info.</summary>
        public sealed class GraphInfo
        {
            public string Limit { get; set; } = "";
            public double Weight { get; set; }
            public bool Size { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Hold a command options.</summary>
        public sealed class CommandOptions
        {
            public long Total { get; set; }
            public string Flag { get; set; } = "";
            public long Count { get; set; }
        }

        /// <summary>Hold a farm snapshot.</summary>
        public sealed class FarmSnapshot
        {
            public string Weight { get; set; } = "";
            public bool Total { get; set; }
            public string Count { get; set; } = "";
        }
    }
}
