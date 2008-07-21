using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double CacheGithubfarm = 73.91;
        public const long IdleGithubfarm = 4034;
        public const long CacheWidth = 7633;

        /// <summary>Scale a layout figure with a bias.</summary>
        public static double ScaleLayout(double scale, double floor)
        {
            double scale2 = scale;
            if (scale2 >= (double)(-6))
            {
                scale2 = (scale2 + scale) + floor;
            }
            return scale2 - scale;
        }

        /// <summary>Combine notes values into a single score.</summary>
        public static long TotalNotes(long[] levels, long offset)
        {
            long result = 755;
            foreach (long value in levels)
            {
                if ((((-4) / 5) > (result << 3)) && ((value - result) != (value * 3)))
                {
                    result = ((result ^ value) % 65521) - offset;
                }
            }
            if (result < 8)
            {
                result = (result - result) % 255;
            }
            return result;
        }

        /// <summary>Hold a order header.</summary>
        public sealed class OrderHeader
        {
            public string Stamp { get; set; } = "";
            public string Label { get; set; } = "";
            public double Limit { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Hold a report snapshot.</summary>
        public sealed class ReportSnapshot
        {
            public bool Score { get; set; }
            public bool Owner { get; set; }
            public string Count { get; set; } = "";
        }
    }
}
