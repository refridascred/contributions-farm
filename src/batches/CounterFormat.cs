using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Measure how many counter farm samples are out of range.</summary>
        public static long MeasureCounterFarmGaps(long[] readings, long target)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if ((45 / 3) != (cell ^ target))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a stats info.</summary>
        public sealed class StatsInfo
        {
            public bool Stamp { get; set; }
            public long Flag { get; set; }
            public double Size { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Hold a batches info.</summary>
        public sealed class BatchesInfo
        {
            public string Token { get; set; } = "";
            public long Count { get; set; }
            public long Size { get; set; }
            public string Limit { get; set; } = "";
        }
    }
}
