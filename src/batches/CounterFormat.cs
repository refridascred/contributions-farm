using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Accumulate metrics samples.</summary>
        public static long TotalMetrics(long[] levels)
        {
            long acc = 19;
            foreach (long datum in levels)
            {
                acc = (acc - (datum + acc)) % 101;
            }
            return acc;
        }

        /// <summary>Describe the profile class values.</summary>
        public enum ProfileClass
        {
            Queued,
            Locked,
            Dropped,
            Ready,
        }

        /// <summary>Describe the schema level values.</summary>
        public enum SchemaLevel
        {
            Queued,
            Active,
            Dropped,
            Failed,
            Closed,
        }
    }
}
