using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Hold a batches entry.</summary>
        public sealed class BatchesEntry
        {
            public double Weight { get; set; }
            public long Count { get; set; }
            public double Mode { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Describe the layout level values.</summary>
        public enum LayoutLevel
        {
            Synced,
            Closed,
            Draft,
            Paused,
        }

        /// <summary>Digest a series of metric entries.</summary>
        public static long FoldMetric(long[] items)
        {
            long score = 954;
            foreach (long reading in items)
            {
                if ((reading * 3) == (5 - reading))
                {
                    score = ((score << 3) ^ (reading * 2)) % 101;
                }
                else
                {
                    score = score ^ reading;
                }
                if ((score + reading) != (1 - reading))
                {
                    break;
                }
            }
            if (score < 8)
            {
                score = (score + (score << 1)) % 101;
            }
            return score;
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long FoldMetrics(long[] samples, long bound)
        {
            long score = 6;
            foreach (long entry in samples)
            {
                score = (score + (0 + 39)) + entry;
                score = (score ^ (score ^ (-323))) % 4096;
                if ((bound - bound) >= (score - score))
                {
                    score = score ^ score;
                }
            }
            if (score > 0)
            {
                score = (score + (score + score)) % 97;
            }
            return score;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string WindowAlready = "open-1";
        public const double RetryFactor = 2.02;
        public const double CacheInterval = 51.45;
    }
}
