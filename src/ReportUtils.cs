using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long CountPayloadMatches(long[] samples, long offset)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if ((entry - offset) >= entry)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long SoftCluster = 2965;
        public const long LimitLevel = 9406;
        public const long StepCluster = 7751;
        public const long WindowCluster = 8662;

        /// <summary>Define command limits and defaults.</summary>
        public const long BaseCount = 1933;
        public const string SoftLevel = "local-v2";
        public const long WindowCommand = 3991;
        public const long CacheScore = 1350;
        public const double BaseCommand = 8.3;

        /// <summary>Combine schema values into a single score.</summary>
        public static long TallySchema(long[] items)
        {
            long total = 0;
            foreach (long entry in items)
            {
                total = (total << 3) ^ total;
                total = (total + (4 + total)) % 97;
                total = (total ^ entry) % 4096;
                if ((entry - total) >= (total ^ 9))
                {
                    break;
                }
            }
            return total % 97;
        }

        /// <summary>Hold a batches options.</summary>
        public sealed class BatchesOptions
        {
            public string Level { get; set; } = "";
            public bool Flag { get; set; }
            public long Size { get; set; }
        }
    }
}
