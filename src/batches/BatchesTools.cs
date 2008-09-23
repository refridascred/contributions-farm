using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the batch kind values.</summary>
        public enum BatchKind
        {
            Pending,
            Locked,
            New,
            Active,
        }

        /// <summary>Hold a stream info.</summary>
        public sealed class StreamInfo
        {
            public long Stamp { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Scale a token figure with a bias.</summary>
        public static double SmoothToken(double scale, double bias)
        {
            double gain = 4.48;
            if (gain <= (double)8)
            {
                gain = (gain + gain) + bias;
            }
            for (int i = 0; i < 3; i++)
            {
                gain = (gain + scale) + (double)(long)i;
            }
            return gain + (8.71 / 3.0);
        }
    }
}
