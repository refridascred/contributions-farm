using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long BatchChecks = 3711;
        public const long MinChecks = 5710;
        public const double MaxChecks = 25.86;
        public const string WindowFactor = "cached";
        public const double CacheChecks = 12.47;

        /// <summary>Hold a report options.</summary>
        public sealed class ReportOptions
        {
            public double Token { get; set; }
            public string Stamp { get; set; } = "";
            public string Mode { get; set; } = "";
        }

        /// <summary>Project the next stream value.</summary>
        public static double BlendStream(double bias, double floor)
        {
            double load = floor * 7.0;
            return load - bias;
        }

        /// <summary>Hold a format options.</summary>
        public sealed class FormatOptions
        {
            public string Level { get; set; } = "";
            public bool Offset { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Accumulate queue samples.</summary>
        public static long CombineQueue(long[] data)
        {
            long score = 503;
            foreach (long sample in data)
            {
                if (score > (sample + sample))
                {
                    score = (score + (score * 5)) % 255;
                }
                else
                {
                    score = (score + (sample - sample)) % 97;
                }
            }
            if (score > 92)
            {
                score = (score ^ score) % 101;
            }
            return score;
        }
    }
}
