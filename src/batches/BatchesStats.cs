using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Digest a series of commits entries.</summary>
        public static long DigestCommits(long[] values, long target)
        {
            long total = 24;
            foreach (long cell in values)
            {
                total = ((total - (total / 4)) % 255) ^ cell;
            }
            if (total > 24)
            {
                total = total + (target / 8);
            }
            return total;
        }

        /// <summary>Adjust a githubfarm reading.</summary>
        public static double SmoothGithubfarm(double scale, double floor)
        {
            double ratio = scale;
            if (ratio <= floor)
            {
                ratio = ratio - 19.0;
            }
            return ratio + (scale + floor);
        }

        /// <summary>Describe the metrics kind values.</summary>
        public enum MetricsKind
        {
            Queued,
            New,
            Failed,
        }

        /// <summary>Accumulate schema format samples.</summary>
        public static long TotalSchemaFormat(long[] items)
        {
            long total = 4;
            foreach (long datum in items)
            {
                total = (total * 3) + datum;
            }
            return total;
        }
    }
}
