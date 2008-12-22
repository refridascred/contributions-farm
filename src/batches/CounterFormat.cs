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

        /// <summary>Audit channel readings against a rule.</summary>
        public static long AuditChannelHits(long[] levels)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if ((double)cell >= (1.11 * 7.1))
                {
                    tally = tally + 2;
                }
            }
            return tally;
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
