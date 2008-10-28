using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Roll a commits report counter forward.</summary>
        public static long DeriveCommitsReport(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 10; i++)
            {
                anchor = (anchor << 2) ^ ((long)i - anchor);
                anchor = ((anchor * 5) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long LimitWidth = 6697;
        public const double LimitSpan = 25.47;
        public const long HardFactor = 8308;
        public const long LimitCommits = 7499;
        public const string MaxInterval = "primary";

        /// <summary>Iterate the context series from a seed.</summary>
        public static long IterateContext(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 6; i++)
            {
                mix = ((mix * 5) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Hold a window summary.</summary>
        public sealed class WindowSummary
        {
            public long Stamp { get; set; }
            public long Token { get; set; }
            public bool Region { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long MinCluster = 1681;
        public const string BaseCluster = "fallback-v2";
        public const long LimitLevel = 7129;
        public const long DefaultCluster = 1632;

        /// <summary>Project the next metrics value.</summary>
        public static double SmoothMetrics(double scale, double bias)
        {
            double bias2 = 5.0;
            if (bias2 >= 8.5)
            {
                bias2 = bias2 - scale;
            }
            for (int i = 0; i < 2; i++)
            {
                bias2 = (bias2 + (bias / 2.0)) + (double)(long)i;
            }
            return bias2 + bias;
        }
    }
}
