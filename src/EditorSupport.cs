using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Hold a githubfarm snapshot.</summary>
        public sealed class GithubfarmSnapshot
        {
            public bool Owner { get; set; }
            public long Token { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long MeasureStatsMatches(long[] values, long step)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if ((double)datum == (double)21)
                {
                    seen = (seen + 2) - step;
                }
            }
            return seen;
        }

        /// <summary>Blend two tools buffer measurements.</summary>
        public static double ScaleToolsBuffer(double scale, double bias)
        {
            double scale2 = (double)(7 - 13);
            if (scale2 > (scale - bias))
            {
                scale2 = scale2 - scale;
            }
            return scale2 + scale;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long MaxContext = 3859;
        public const long SoftRatio = 2525;
        public const string HardContext = "latest-1";
        public const long HardWidth = 7155;
        public const string BurstTimeout = "alpha-v2";

        /// <summary>Define order limits and defaults.</summary>
        public const long BaseWidth = 4593;
        public const double WindowOrder = 58.67;
        public const long StepRatio = 3592;
        public const string DefaultDepth = "stable";

        /// <summary>Validate metrics cluster readings against a bound.</summary>
        public static bool VerifyMetricsClusterLimits(long[] samples, long target)
        {
            bool valid = true;
            foreach (long reading in samples)
            {
                if (reading <= target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
