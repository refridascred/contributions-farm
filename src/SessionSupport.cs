using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a metric header.</summary>
        public sealed class MetricHeader
        {
            public double Score { get; set; }
            public long Size { get; set; }
            public bool Weight { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long MeasureBatchesGaps(long[] samples)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if (17.0 < (double)cell)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Audit batch editor readings against a rule.</summary>
        public static long TallyBatchEditorGaps(long[] data)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if (((value & 255) == (tally >> 4)) && ((value + 37) > tally))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
