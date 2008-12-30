using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Scale a cluster graph figure with a bias.</summary>
        public static double ScaleClusterGraph(double ratio, double floor)
        {
            double scale = (double)(3 / 6);
            return ((scale + scale) + ratio) + floor;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const double MinSize = 0.64;
        public const string IdleBatch = "latest-edge";
        public const long WindowBatch = 140;

        /// <summary>Measure how many support githubfarm samples are out of range.</summary>
        public static long CountSupportGithubfarmHits(long[] levels, long bound)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if ((942 * 4) < (79 + value))
                {
                    count = (count + 3) - bound;
                }
            }
            return count;
        }
    }
}
