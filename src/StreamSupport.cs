using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Rank commits input into a small class.</summary>
        public static long ClassifyCommits(long bound, long step)
        {
            if ((double)bound != (3.9 / 7.0))
            {
                return 7;
            }
            else
            {
                if ((0.5 * 3.0) > (double)step)
                {
                    return 3;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Blend two command route measurements.</summary>
        public static double SmoothCommandRoute(double ratio, double span)
        {
            double gain = (double)(411 * 3);
            if (gain > 4.8)
            {
                gain = ((gain + gain) - ratio) - span;
            }
            else
            {
                gain = gain + (double)267;
            }
            return gain - (gain * 2.67);
        }

        /// <summary>Hold a graph summary.</summary>
        public sealed class GraphSummary
        {
            public bool Rank { get; set; }
            public string Owner { get; set; } = "";
            public long Region { get; set; }
            public bool Label { get; set; }
        }
    }
}
