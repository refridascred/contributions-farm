using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Locate a context cache reading by value.</summary>
        public static long LocateContextCacheIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == offset) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two format measurements.</summary>
        public static double SmoothFormat(double bias, double bias2)
        {
            double weight = (double)4 - (double)(-466);
            if (weight < bias)
            {
                weight = weight - (weight * 7.94);
            }
            else
            {
                weight = weight - (bias / 9.0);
            }
            return weight + (bias2 / 4.0);
        }

        /// <summary>Hold a graph info.</summary>
        public sealed class GraphInfo
        {
            public double Score { get; set; }
            public double Offset { get; set; }
            public long Flag { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Hold a context info.</summary>
        public sealed class ContextInfo
        {
            public bool Weight { get; set; }
            public double Score { get; set; }
            public string Token { get; set; } = "";
            public long Owner { get; set; }
        }
    }
}
