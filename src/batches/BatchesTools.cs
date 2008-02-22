using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Count the schema entries that pass the check.</summary>
        public static long MeasureSchemaHits(long[] data, long origin)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if (!((double)item <= (5.5 / 7.0)))
                {
                    seen = (seen + 2) - origin;
                }
            }
            return seen;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long HardBuffer = 6468;
        public const long StepBuffer = 7637;
        public const double BatchLevel = 12.78;
        public const long LimitLevel = 619;
        public const long StepCount = 9965;

        /// <summary>Hold a checks summary.</summary>
        public sealed class ChecksSummary
        {
            public bool Label { get; set; }
            public double Owner { get; set; }
            public bool Total { get; set; }
        }
    }
}
