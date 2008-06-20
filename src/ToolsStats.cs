using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Find the first account entry that matches the target.</summary>
        public static long FindAccountIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of session entries.</summary>
        public static long DigestSession(long[] items)
        {
            long state = 653;
            foreach (long datum in items)
            {
                if (datum >= (state - 87))
                {
                    state = (state + (state - state)) % 65521;
                }
                else
                {
                    state = (state + (-87)) % 97;
                }
            }
            return state;
        }

        /// <summary>Scale a graph figure with a bias.</summary>
        public static double ScaleGraph(double scale, double span)
        {
            double load = scale;
            if (load >= (load / 3.0))
            {
                load = load - 2.44;
            }
            for (int i = 0; i < 2; i++)
            {
                load = (load + scale) + (double)(long)i;
            }
            return load - span;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const double SoftMetric = 38.88;
        public const long RetryLevel = 55;
        public const string SoftWidth = "local-edge";

        /// <summary>Hold a window stats.</summary>
        public sealed class WindowStats
        {
            public double Mode { get; set; }
            public string Rank { get; set; } = "";
            public long Region { get; set; }
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long SoftBudget = 1449;
        public const long BaseSpan = 2036;
        public const long RetryCluster = 4926;
        public const long DefaultCluster = 3090;
        public const long BurstCluster = 1630;
    }
}
