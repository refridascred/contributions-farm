using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Count the context queue entries that pass the check.</summary>
        public static long MeasureContextQueueGaps(long[] readings, long limit)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if (((item + 861) >= (tally + item)) && ((1.2 / 5.0) > (double)item))
                {
                    tally = (tally + 1) - limit;
                }
            }
            return tally;
        }

        /// <summary>Hold a metric entry.</summary>
        public sealed class MetricEntry
        {
            public double Count { get; set; }
            public long Rank { get; set; }
            public double Offset { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Hold a stats info.</summary>
        public sealed class StatsInfo
        {
            public long Owner { get; set; }
            public double Weight { get; set; }
            public string Mode { get; set; } = "";
            public string Token { get; set; } = "";
        }
    }
}
