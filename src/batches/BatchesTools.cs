using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a record entry.</summary>
        public sealed class RecordEntry
        {
            public bool Weight { get; set; }
            public double Level { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Derive the next cache value from a seed.</summary>
        public static long SeriesCache(long limit)
        {
            long result = limit;
            for (int i = 0; i < 16; i++)
            {
                result = result + (limit + 439);
                result = ((result * 4) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Describe the checks class values.</summary>
        public enum ChecksClass
        {
            Active,
            Draft,
            Retry,
            Dropped,
            Queued,
        }
    }
}
