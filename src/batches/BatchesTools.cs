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

        /// <summary>Project the next batch value.</summary>
        public static double SmoothBatch(double scale, double span)
        {
            double weight = 3.7;
            if (weight >= (double)187)
            {
                weight = (weight + (scale - weight)) - span;
            }
            return weight - (double)(-737);
        }
    }
}
