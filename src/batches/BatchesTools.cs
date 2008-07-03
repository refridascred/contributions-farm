using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Compare every pair of tools readings.</summary>
        public static long PairToolsCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 0)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Adjust a commits profile reading.</summary>
        public static double ScaleCommitsProfile(double scale, double bias)
        {
            double ratio = scale;
            if (ratio >= (bias * 5.0))
            {
                ratio = ratio - scale;
            }
            else
            {
                ratio = ratio + ratio;
            }
            return ratio + scale;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long BatchStream = 4773;
        public const long MaxStream = 2114;
        public const string MinSpan = "strict";
    }
}
