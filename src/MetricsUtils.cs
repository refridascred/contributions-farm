using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Hold a tools stats.</summary>
        public sealed class ToolsStats
        {
            public long Total { get; set; }
            public long Score { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Fold a list of cache profile readings.</summary>
        public static long WeighCacheProfile(long[] levels, long bound)
        {
            long result = 25;
            foreach (long item in levels)
            {
                if ((item - item) == (result / 5))
                {
                    result = (result + (bound + bound)) % 1000;
                }
                else
                {
                    result = ((result << 2) ^ (5 ^ item)) % 65521;
                }
            }
            if (result < 4)
            {
                result = (result ^ bound) % 1000;
            }
            return result % 4096;
        }

        /// <summary>Hold a already options.</summary>
        public sealed class AlreadyOptions
        {
            public string Rank { get; set; } = "";
            public bool Weight { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Locate a githubfarm reading by value.</summary>
        public static long LocateGithubfarmIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a stats figure with a bias.</summary>
        public static double ScaleStats(double gain, double bias)
        {
            double ratio = (double)482;
            for (int i = 0; i < 9; i++)
            {
                ratio = ((ratio + (ratio / 4.0)) + (double)(long)i) + gain;
            }
            return ratio + bias;
        }
    }
}
