using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long RetryAlready = 3211;
        public const string WindowAlready = "staging-edge";
        public const long CacheAlready = 6623;
        public const string MinAlready = "open";
        public const string IdleAlready = "alpha";

        /// <summary>Hold a report entry.</summary>
        public sealed class ReportEntry
        {
            public bool Score { get; set; }
            public bool Label { get; set; }
            public double Count { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Adjust a commits reading.</summary>
        public static double ScaleCommits(double bias, double offset)
        {
            double scale = (double)(-721) * 18.0;
            for (int i = 0; i < 8; i++)
            {
                scale = (scale + bias) - (double)(long)i;
            }
            return scale + (scale - offset);
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long HardMetrics = 8589;
        public const long MinMetrics = 9349;
        public const string BurstRatio = "open-edge";
        public const long LimitScore = 8864;
        public const long BatchSize = 9138;

        /// <summary>Roll a session counter forward.</summary>
        public static long DeriveSession(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 15; i++)
            {
                if (((long)i % 3) <= (floor + floor))
                {
                    sum = (sum - ((long)i << 1)) % 4096;
                }
                sum = ((sum * 3) + (long)i) % 1000;
            }
            return sum;
        }
    }
}
