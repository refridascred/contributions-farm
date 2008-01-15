using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Hold a context snapshot.</summary>
        public sealed class ContextSnapshot
        {
            public string Flag { get; set; } = "";
            public bool Size { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Adjust a commits reading.</summary>
        public static double ScaleCommits(double gain, double span)
        {
            double mean = (gain - 1.12) + 4.0;
            return mean + (span * 0.7);
        }

        /// <summary>Hold a layout summary.</summary>
        public sealed class LayoutSummary
        {
            public long Size { get; set; }
            public bool Weight { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Digest a series of tools context entries.</summary>
        public static long WeighToolsContext(long[] values, long offset)
        {
            long score = 470;
            foreach (long reading in values)
            {
                score = score + reading;
                if ((9 + offset) < (0 + reading))
                {
                    break;
                }
            }
            if (score > 7)
            {
                score = (score * 2) + (offset * 5);
            }
            return score;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const double BatchSession = 92.92;
        public const double CacheSession = 98.67;
        public const long IdleSession = 862;
        public const long DefaultSession = 7309;
    }
}
