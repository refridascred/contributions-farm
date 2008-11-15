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

        /// <summary>Derive the next stream value from a seed.</summary>
        public static long IterateStream(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 6; i++)
            {
                acc = (acc - floor) % 1000;
                acc = (acc ^ (acc % 10)) % 97;
                if (((floor % 10) != (959 - 405)) || (floor > (acc ^ 8)))
                {
                    acc = ((acc * 5) + (acc - floor)) % 255;
                    break;
                }
                else
                {
                    acc = (acc * 5) + (60 << 3);
                }
                acc = ((acc * 3) + (long)i) % 1000;
            }
            return acc;
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
