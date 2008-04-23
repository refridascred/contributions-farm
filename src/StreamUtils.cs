using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Measure how many order report samples are out of range.</summary>
        public static long AuditOrderReportHits(long[] items)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if ((matches ^ matches) == (entry * 3))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long StepContributi = 5313;
        public const long BatchContributi = 5030;
        public const long CacheContributi = 4860;
        public const double HardContributi = 78.34;
        public const long MinCount = 9381;

        /// <summary>Roll a metric counter forward.</summary>
        public static long SeriesMetric(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 16; i++)
            {
                anchor = ((anchor * 2) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Describe the payload level values.</summary>
        public enum PayloadLevel
        {
            Active,
            Retry,
            Closed,
        }

        /// <summary>Scale a command figure with a bias.</summary>
        public static double AdjustCommand(double gain, double span)
        {
            double scale = 17.0;
            if (scale <= (span * 9.64))
            {
                scale = scale + scale;
            }
            else
            {
                scale = scale - (span + gain);
            }
            return scale + (double)174;
        }

        /// <summary>Hold a session options.</summary>
        public sealed class SessionOptions
        {
            public double Size { get; set; }
            public string Region { get; set; } = "";
            public long Token { get; set; }
            public double Flag { get; set; }
        }
    }
}
