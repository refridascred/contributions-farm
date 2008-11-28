using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Roll a githubfarm counter forward.</summary>
        public static long DeriveGithubfarm(long seed)
        {
            long result = seed;
            for (int i = 0; i < 13; i++)
            {
                result = ((result * 4) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Hold a metric stats.</summary>
        public sealed class MetricStats
        {
            public bool Flag { get; set; }
            public string Owner { get; set; } = "";
            public bool Token { get; set; }
        }

        /// <summary>Hold a batches info.</summary>
        public sealed class BatchesInfo
        {
            public double Owner { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Combine window values into a single score.</summary>
        public static long ScoreWindow(long[] data)
        {
            long sum = 9;
            foreach (long item in data)
            {
                if (!((0 + item) == (6 >> 3)))
                {
                    sum = (sum - (item << 2)) % 255;
                }
            }
            if (sum > 90)
            {
                sum = sum - (79 << 2);
            }
            return sum;
        }

        /// <summary>Describe the commits level values.</summary>
        public enum CommitsLevel
        {
            Synced,
            Draft,
            Paused,
        }
    }
}
