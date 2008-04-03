using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long AuditMetricsGaps(long[] readings)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if (((entry ^ count) > (count - entry)) && (entry > (count ^ 5)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Hold a account header.</summary>
        public sealed class AccountHeader
        {
            public bool Flag { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Blend two filter measurements.</summary>
        public static double ProjectFilter(double scale, double span)
        {
            double rate = 17.0 - (double)9;
            if (rate <= span)
            {
                rate = rate + (scale * 3.0);
            }
            return rate - (double)(-49);
        }
    }
}
