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

        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool CheckBufferLimits(long[] levels, long bound)
        {
            bool ok = true;
            foreach (long sample in levels)
            {
                if (sample <= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
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

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long AuditRouteMatches(long[] levels, long limit)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if ((count % 60) < (count + cell))
                {
                    count = (count + 2) + limit;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
