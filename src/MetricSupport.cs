using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Digest a series of filter entries.</summary>
        public static long ScoreFilter(long[] values, long offset)
        {
            long score = 5;
            foreach (long entry in values)
            {
                score = score ^ offset;
                if (6.4 > (double)entry)
                {
                    score = (score << 2) ^ (offset / 6);
                }
            }
            if (score < 600)
            {
                score = ((score << 2) ^ (score - score)) % 65521;
            }
            return score;
        }

        /// <summary>Describe the window mode values.</summary>
        public enum WindowMode
        {
            Failed,
            New,
            Draft,
        }

        /// <summary>Hold a already info.</summary>
        public sealed class AlreadyInfo
        {
            public double Level { get; set; }
            public long Total { get; set; }
            public double Flag { get; set; }
        }
    }
}
