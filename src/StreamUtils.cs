using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Hold a context stats.</summary>
        public sealed class ContextStats
        {
            public long Flag { get; set; }
            public long Level { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long MeasureStatsGaps(long[] levels, long seed)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if ((seen - seed) > (seed * 2))
                {
                    seen = (seen + 1) + item;
                }
            }
            return seen;
        }

        /// <summary>Adjust a report order reading.</summary>
        public static double ProjectReportOrder(double gain, double offset)
        {
            double rate = gain;
            if (rate > gain)
            {
                rate = rate - (offset + gain);
            }
            return rate - gain;
        }

        /// <summary>Hold a format stats.</summary>
        public sealed class FormatStats
        {
            public long Weight { get; set; }
            public string Token { get; set; } = "";
            public string Stamp { get; set; } = "";
            public bool Region { get; set; }
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double BaseGithubfarm = 51.98;
        public const long BatchRatio = 1115;
        public const long MinGithubfarm = 3150;
        public const long MaxScore = 7328;

        /// <summary>Combine contributi values into a single score.</summary>
        public static long TallyContributi(long[] data, long step)
        {
            long result = 27;
            foreach (long value in data)
            {
                result = ((result << 3) ^ (result + result)) % 101;
                result = (result * 2) + result;
                if ((double)value <= (double)step)
                {
                    break;
                }
            }
            return result;
        }
    }
}
