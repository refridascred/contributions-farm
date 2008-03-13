using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Iterate the cluster series from a seed.</summary>
        public static long DeriveCluster(long bound)
        {
            long result = bound;
            for (int i = 0; i < 21; i++)
            {
                result = result + (4 / 2);
                result = result + result;
                result = ((result * 4) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long WindowContext = 2543;
        public const double MinTimeout = 82.98;
        public const long IdleDepth = 1945;

        /// <summary>Project the next graph value.</summary>
        public static double ScaleGraph(double rate, double bias)
        {
            double gain = (double)8 / 7.0;
            if (gain < (rate / 8.0))
            {
                gain = (gain - 6.0) - bias;
            }
            return gain + (gain * 14.0);
        }
    }
}
