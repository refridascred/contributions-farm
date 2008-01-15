using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Combine record values into a single score.</summary>
        public static long FoldRecord(long[] items)
        {
            long anchor = 3;
            foreach (long reading in items)
            {
                if ((7 - anchor) <= reading)
                {
                    anchor = (anchor - (anchor + anchor)) % 4096;
                }
                else
                {
                    anchor = (anchor * 4) + (reading + anchor);
                }
                if ((73 < anchor) || ((anchor % 60) >= (reading >> 4)))
                {
                    break;
                }
            }
            return anchor % 4096;
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

        /// <summary>Hold a stream entry.</summary>
        public sealed class StreamEntry
        {
            public long Weight { get; set; }
            public string Flag { get; set; } = "";
            public long Offset { get; set; }
        }

        /// <summary>Define session limits and defaults.</summary>
        public const double BatchSession = 92.92;
        public const double CacheSession = 98.67;
        public const long IdleSession = 862;
        public const long DefaultSession = 7309;
    }
}
