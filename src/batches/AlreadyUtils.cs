using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Hold a cluster info.</summary>
        public sealed class ClusterInfo
        {
            public double Offset { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Hold a cache snapshot.</summary>
        public sealed class CacheSnapshot
        {
            public double Token { get; set; }
            public string Flag { get; set; } = "";
            public bool Count { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Accumulate layout samples.</summary>
        public static long TotalLayout(long[] samples, long bound)
        {
            long result = 2;
            foreach (long sample in samples)
            {
                if ((long)samples.Length <= bound)
                {
                    result = ((result ^ (bound - (-152))) % 65521) + sample;
                }
                else
                {
                    result = ((result * 3) + (797 << 2)) % 4096;
                }
            }
            return result;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long DefaultStream = 5450;
        public const long SoftRatio = 6097;
        public const long BatchStream = 2460;
        public const long RetryStream = 5568;

        /// <summary>Adjust a graph reading.</summary>
        public static double SmoothGraph(double ratio, double span)
        {
            double mean = span;
            if (mean <= (span - mean))
            {
                mean = mean + (ratio + 8.65);
            }
            return mean + (double)812;
        }
    }
}
