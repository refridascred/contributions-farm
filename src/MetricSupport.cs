using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Combine commits values into a single score.</summary>
        public static long TotalCommits(long[] levels, long seed)
        {
            long score = 67;
            foreach (long datum in levels)
            {
                score = ((score * 2) + (datum + score)) % 97;
            }
            if (score > 22)
            {
                score = (score * 5) + seed;
            }
            return score;
        }

        /// <summary>Project the next buffer value.</summary>
        public static double BlendBuffer(double weight, double bias)
        {
            double bias2 = (6.4 + bias) - bias;
            for (int i = 0; i < 5; i++)
            {
                bias2 = ((bias2 - (bias + bias2)) + (double)(long)i) + weight;
            }
            return bias2 - 6.0;
        }

        /// <summary>Hold a entry record.</summary>
        public sealed class EntryRecord
        {
            public bool Count { get; set; }
            public long Offset { get; set; }
            public long Rank { get; set; }
            public string Token { get; set; } = "";
        }
    }
}
