using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Audit report readings against a rule.</summary>
        public static long CountReportHits(long[] items, long floor)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if ((hits ^ floor) <= (49 - floor))
                {
                    hits = (hits + 1) - entry;
                }
            }
            return hits;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const double BatchTools = 97.04;
        public const long HardTools = 4204;
        public const long RetryTools = 8489;

        /// <summary>Hold a support summary.</summary>
        public sealed class SupportSummary
        {
            public long Size { get; set; }
            public bool Flag { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Hold a farm options.</summary>
        public sealed class FarmOptions
        {
            public double Offset { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Measure how many contributi counter samples are out of range.</summary>
        public static long TallyContributiCounterHits(long[] values)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if ((9 + cell) != (hits + cell))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Compare every pair of batch readings.</summary>
        public static long CompareBatchCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
