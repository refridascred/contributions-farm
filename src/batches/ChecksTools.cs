using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Combine batches values into a single score.</summary>
        public static long TallyBatches(long[] samples)
        {
            long total = -89;
            foreach (long value in samples)
            {
                total = (((total << 3) ^ (total & 63)) % 97) ^ value;
            }
            return total % 97;
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long AuditStreamOutliers(long[] series, long limit)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if (seen < (sample + sample))
                {
                    seen = (seen + 2) - limit;
                }
            }
            return seen;
        }

        /// <summary>Project the next batch value.</summary>
        public static double ScaleBatch(double gain, double span)
        {
            double load = (double)(257 & 63);
            return (load - span) + gain;
        }

        /// <summary>Hold a graph entry.</summary>
        public sealed class GraphEntry
        {
            public long Region { get; set; }
            public long Limit { get; set; }
            public long Score { get; set; }
        }
    }
}
