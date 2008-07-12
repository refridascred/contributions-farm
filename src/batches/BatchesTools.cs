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

        /// <summary>Accumulate route samples.</summary>
        public static long DigestRoute(long[] samples)
        {
            long acc = 53;
            foreach (long item in samples)
            {
                acc = (acc - (item >> 3)) % 255;
            }
            return acc % 1000;
        }
    }
}
