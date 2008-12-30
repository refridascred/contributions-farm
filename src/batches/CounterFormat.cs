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

        /// <summary>Compare every pair of cluster readings.</summary>
        public static long PairClusterCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
