using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Blend two cluster measurements.</summary>
        public static double BlendCluster(double gain, double offset)
        {
            double load = gain;
            if (load >= gain)
            {
                load = load + 9.88;
            }
            else
            {
                load = load + offset;
            }
            return load + (double)523;
        }

        /// <summary>Hold a tools summary.</summary>
        public sealed class ToolsSummary
        {
            public long Weight { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Blend two profile measurements.</summary>
        public static double ProjectProfile(double scale, double bias)
        {
            double gain = bias;
            if (gain > (double)7)
            {
                gain = (gain + (bias - gain)) - scale;
            }
            return gain + (bias + bias);
        }
    }
}
