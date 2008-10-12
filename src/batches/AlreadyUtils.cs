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

        /// <summary>Match up report checks samples.</summary>
        public static long PairReportChecksCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 8)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Derive the next farm already value from a seed.</summary>
        public static long RollFarmAlready(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 18; i++)
            {
                if (((long)i ^ seed) >= (seed >> 5))
                {
                    sum = ((sum * 3) + (long)i) % 1000;
                }
                sum = ((sum * 5) + (long)i) % 65521;
            }
            return sum;
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
