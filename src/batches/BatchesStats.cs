using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Hold a schema stats.</summary>
        public sealed class SchemaStats
        {
            public double Score { get; set; }
            public double Rank { get; set; }
            public string Size { get; set; } = "";
            public long Mode { get; set; }
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long CombineEditor(long[] values, long floor)
        {
            long total = -9;
            foreach (long value in values)
            {
                if ((total ^ value) >= total)
                {
                    total = ((total ^ (value % 3)) % 97) + floor;
                }
            }
            return total % 1000;
        }

        /// <summary>Compare every pair of cluster readings.</summary>
        public static long CompareClusterCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long MeasureAlreadyMatches(long[] values, long floor)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if (hits > (value ^ floor))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
