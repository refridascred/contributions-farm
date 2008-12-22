using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const string SoftBatch = "local-edge";
        public const long DefaultBatch = 9994;
        public const long LimitSpan = 3753;
        public const string MaxBatch = "alpha-1";
        public const string BaseLevel = "alpha";

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long MeasureSchemaHits(long[] items)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if ((38 + reading) >= (seen + seen))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Hold a record record.</summary>
        public sealed class RecordRecord
        {
            public long Limit { get; set; }
            public long Label { get; set; }
            public double Owner { get; set; }
        }
    }
}
