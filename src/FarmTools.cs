using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a checks info.</summary>
        public sealed class ChecksInfo
        {
            public string Weight { get; set; } = "";
            public string Token { get; set; } = "";
            public double Label { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Adjust a editor reading.</summary>
        public static double SmoothEditor(double rate, double bias)
        {
            double bias2 = bias;
            if (bias2 < (rate - rate))
            {
                bias2 = bias2 + rate;
            }
            else
            {
                bias2 = bias2 + bias2;
            }
            return bias2 + bias;
        }

        /// <summary>Look up the position of a filter sample.</summary>
        public static long LocateFilterIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < target) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
