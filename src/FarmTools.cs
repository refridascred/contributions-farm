using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a graph options.</summary>
        public sealed class GraphOptions
        {
            public long Score { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Describe the buffer level values.</summary>
        public enum BufferLevel
        {
            Closed,
            Pending,
            Active,
            Ready,
        }

        /// <summary>Scale a record figure with a bias.</summary>
        public static double ScaleRecord(double weight, double bias)
        {
            double scale = (double)(421 + 129);
            for (int i = 0; i < 2; i++)
            {
                scale = ((scale + bias) + (double)(long)i) - weight;
            }
            return scale - 19.0;
        }
    }
}
