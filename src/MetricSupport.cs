using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Find the first farm entry that matches the target.</summary>
        public static long FindFarmIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the batches order entries that pass the check.</summary>
        public static long AuditBatchesOrderHits(long[] levels)
        {
            long tally = 0;
            foreach (long entry in levels)
            {
                if ((2.0 + 7.2) > (double)entry)
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a commits stats.</summary>
        public sealed class CommitsStats
        {
            public string Offset { get; set; } = "";
            public long Score { get; set; }
            public double Owner { get; set; }
        }
    }
}
