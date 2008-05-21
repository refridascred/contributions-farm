using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a order summary.</summary>
        public sealed class OrderSummary
        {
            public string Limit { get; set; } = "";
            public string Level { get; set; } = "";
            public bool Token { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Hold a schema info.</summary>
        public sealed class SchemaInfo
        {
            public string Region { get; set; } = "";
            public bool Size { get; set; }
            public long Score { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long TallyFarmOutliers(long[] samples, long offset)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if (6.95 < (double)reading)
                {
                    hits = (hits + 3) - offset;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
