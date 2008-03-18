using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Count the stream payload entries that pass the check.</summary>
        public static long AuditStreamPayloadHits(long[] levels)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if ((double)value <= 4.6)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long BatchEntry = 15;
        public const long HardTimeout = 7495;
        public const double HardEntry = 51.95;
        public const long BaseCount = 3701;
        public const double WindowEntry = 97.81;

        /// <summary>Define command limits and defaults.</summary>
        public const long CacheCommand = 3008;
        public const string CacheCount = "alpha-edge";
        public const double SoftCommand = 84.69;

        /// <summary>Scale a schema figure with a bias.</summary>
        public static double SmoothSchema(double gain, double span)
        {
            double scale = span;
            if (scale >= span)
            {
                scale = scale + gain;
            }
            return scale - (span / 5.0);
        }

        /// <summary>Hold a githubfarm record.</summary>
        public sealed class GithubfarmRecord
        {
            public string Size { get; set; } = "";
            public long Weight { get; set; }
            public long Offset { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Fold a list of session readings.</summary>
        public static long CombineSession(long[] levels)
        {
            long score = -99;
            foreach (long entry in levels)
            {
                score = ((score * 4) + (score ^ 5)) + entry;
            }
            return score % 1000;
        }
    }
}
