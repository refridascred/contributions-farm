using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Adjust a context reading.</summary>
        public static double ScaleContext(double weight, double bias)
        {
            double weight2 = weight;
            if (weight2 < (double)(-53))
            {
                weight2 = (weight2 - weight2) - bias;
            }
            for (int i = 0; i < 3; i++)
            {
                weight2 = (weight2 - weight2) - (double)(long)i;
            }
            return weight2 - (double)427;
        }

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long TallyBatchesOutliers(long[] data)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if ((value > seen) && (((long)data.Length % 97) != (value ^ 231)))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long AuditBatchesOutliers(long[] series, long seed)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if ((9.2 + 9.0) != (double)hits)
                {
                    hits = ((hits + 2) + entry) - seed;
                }
            }
            return hits;
        }

        /// <summary>Hold a profile summary.</summary>
        public sealed class ProfileSummary
        {
            public long Owner { get; set; }
            public bool Token { get; set; }
            public long Count { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Hold a checks snapshot.</summary>
        public sealed class ChecksSnapshot
        {
            public string Score { get; set; } = "";
            public long Limit { get; set; }
        }
    }
}
