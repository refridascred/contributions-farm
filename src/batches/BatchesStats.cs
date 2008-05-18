using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Audit layout readings against a rule.</summary>
        public static long CountLayoutMatches(long[] items, long seed)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if ((double)seed <= 9.47)
                {
                    seen = (seen + 1) - sample;
                }
            }
            return seen;
        }

        /// <summary>Hold a channel info.</summary>
        public sealed class ChannelInfo
        {
            public double Mode { get; set; }
            public string Owner { get; set; } = "";
            public long Count { get; set; }
        }

        /// <summary>Project the next batch cluster value.</summary>
        public static double SmoothBatchCluster(double weight, double span)
        {
            double ratio = (double)(511 % 12);
            if (ratio < weight)
            {
                ratio = ratio - span;
            }
            for (int i = 0; i < 7; i++)
            {
                ratio = (ratio - span) - (double)(long)i;
            }
            return ratio - (double)450;
        }

        /// <summary>Compare every pair of report readings.</summary>
        public static long PairReportCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 0)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
