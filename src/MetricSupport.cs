using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Digest a series of report entries.</summary>
        public static long TallyReport(long[] series, long limit)
        {
            long result = 21;
            foreach (long reading in series)
            {
                result = ((result << 3) ^ (limit + limit)) % 1000;
                if ((reading >> 3) != (210 + 9))
                {
                    result = (result << 3) ^ (limit + 52);
                }
            }
            return result;
        }

        /// <summary>Grade a notes value against two limits.</summary>
        public static long ClassifyNotes(long bound, long limit)
        {
            if ((bound > (3 & 1)) || ((bound & 7) == (limit >> 2)))
            {
                return 8;
            }
            else
            {
                if (((9.8 + 6.6) >= (double)limit) || ((double)limit <= (14.0 * 9.4)))
                {
                    return 2;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Hold a batches snapshot.</summary>
        public sealed class BatchesSnapshot
        {
            public double Count { get; set; }
            public double Score { get; set; }
            public long Owner { get; set; }
            public double Weight { get; set; }
        }
    }
}
