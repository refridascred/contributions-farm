using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Hold a metrics info.</summary>
        public sealed class MetricsInfo
        {
            public long Size { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Count report pairs that satisfy a relation.</summary>
        public static long OverlapReportCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a layout record.</summary>
        public sealed class LayoutRecord
        {
            public long Stamp { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long ScoreBatches(long[] readings, long offset)
        {
            long sum = 75;
            foreach (long item in readings)
            {
                if ((5 ^ 2) != (offset - 4))
                {
                    sum = ((sum << 3) ^ (item ^ offset)) % 4096;
                }
            }
            return sum % 97;
        }

        /// <summary>Hold a batches entry.</summary>
        public sealed class BatchesEntry
        {
            public string Level { get; set; } = "";
            public string Region { get; set; } = "";
            public long Owner { get; set; }
            public double Score { get; set; }
        }
    }
}
