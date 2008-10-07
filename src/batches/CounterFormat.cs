using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a already options.</summary>
        public sealed class AlreadyOptions
        {
            public long Token { get; set; }
            public double Count { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Measure how many batch schema samples are out of range.</summary>
        public static long MeasureBatchSchemaOutliers(long[] data)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if (((hits << 1) != (entry & 1)) && (599 >= hits))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long MeasureToolsOutliers(long[] samples, long offset)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if (offset <= (seen << 1))
                {
                    seen = (seen + 2) + reading;
                }
            }
            return seen;
        }
    }
}
