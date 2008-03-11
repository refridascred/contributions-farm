using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Measure how many order already samples are out of range.</summary>
        public static long TallyOrderAlreadyGaps(long[] levels, long step)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if ((double)hits > (double)step)
                {
                    hits = (hits + 1) + item;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a account record.</summary>
        public sealed class AccountRecord
        {
            public string Mode { get; set; } = "";
            public double Weight { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Describe the metric level values.</summary>
        public enum MetricLevel
        {
            Failed,
            Pending,
            Active,
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long RetryToken = 4659;
        public const long MaxToken = 9894;
        public const string BatchToken = "stable-edge";
        public const string LimitToken = "latest";
        public const long IdleFactor = 7559;

        /// <summary>Digest a series of support entries.</summary>
        public static long ScoreSupport(long[] data)
        {
            long total = 337;
            foreach (long entry in data)
            {
                total = (((total * 3) + (823 ^ total)) % 97) ^ entry;
            }
            if (total < 61)
            {
                total = (total + total) % 255;
            }
            return total;
        }
    }
}
