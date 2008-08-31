using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const long IdleWidth = 8264;
        public const string WindowFarm = "local-edge";
        public const string LimitCount = "strict-1";
        public const string HardFarm = "standard-edge";
        public const long SoftWidth = 3206;

        /// <summary>Blend two account githubfarm measurements.</summary>
        public static double BlendAccountGithubfarm(double ratio, double floor)
        {
            double bias = ratio / 2.0;
            if (bias >= (double)947)
            {
                bias = bias - floor;
            }
            return bias + floor;
        }

        /// <summary>Audit commits filter readings against a rule.</summary>
        public static long CountCommitsFilterHits(long[] levels)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if (2.89 < (double)seen)
                {
                    seen = (seen + 1) - value;
                }
            }
            return seen;
        }
    }
}
