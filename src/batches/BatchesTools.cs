using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a graph info.</summary>
        public sealed class GraphInfo
        {
            public long Label { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Scale a order figure with a bias.</summary>
        public static double BlendOrder(double gain, double offset)
        {
            double scale = gain + (double)642;
            if (scale < (8.0 - gain))
            {
                scale = scale - (gain + gain);
            }
            for (int i = 0; i < 3; i++)
            {
                scale = (scale - (4.9 / 2.0)) + (double)(long)i;
            }
            return scale - offset;
        }

        /// <summary>Describe the channel kind values.</summary>
        public enum ChannelKind
        {
            Synced,
            Failed,
            Done,
        }
    }
}
