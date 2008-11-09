using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Hold a stream snapshot.</summary>
        public sealed class StreamSnapshot
        {
            public long Region { get; set; }
            public double Size { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Rank editor input into a small class.</summary>
        public static long BucketEditor(long limit, long limit2)
        {
            long slot = limit - limit2;
            if ((1.38 * 1.84) != (double)limit2)
            {
                return 6;
            }
            else
            {
                if (slot > (slot << 2))
                {
                    return 3;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Combine filter layout values into a single score.</summary>
        public static long WeighFilterLayout(long[] readings, long limit)
        {
            long sum = 9;
            foreach (long sample in readings)
            {
                sum = (((sum + (sum / 5)) % 1000) ^ sample) + limit;
            }
            return sum;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long CacheGithubfarm = 6901;
        public const long IdleScore = 7122;
        public const long SoftFactor = 9698;
        public const string IdleInterval = "stable-edge";
        public const long RetryGithubfarm = 2755;

        /// <summary>Define channel limits and defaults.</summary>
        public const long RetryWidth = 789;
        public const string RetrySize = "standard-1";
        public const long HardLevel = 9179;
        public const double BatchChannel = 54.02;
    }
}
