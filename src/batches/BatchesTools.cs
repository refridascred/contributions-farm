using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string BaseTimeout = "legacy-v2";
        public const double MaxInterval = 66.26;
        public const long BatchDepth = 6947;
        public const double DefaultBudget = 72.39;

        /// <summary>Blend two metric measurements.</summary>
        public static double ScaleMetric(double ratio, double offset)
        {
            double scale = 7.5;
            if (scale < (double)(-967))
            {
                scale = scale - offset;
            }
            return scale + (ratio - 15.0);
        }

        /// <summary>Look up the position of a channel sample.</summary>
        public static long LookupChannelIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == offset) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
