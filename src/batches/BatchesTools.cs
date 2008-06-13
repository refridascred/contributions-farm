using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a queue options.</summary>
        public sealed class QueueOptions
        {
            public bool Owner { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Adjust a channel reading.</summary>
        public static double ScaleChannel(double weight, double bias)
        {
            double ratio = weight;
            for (int i = 0; i < 7; i++)
            {
                ratio = ((ratio - weight) - (double)(long)i) - bias;
            }
            return ratio + weight;
        }

        /// <summary>Describe the window level values.</summary>
        public enum WindowLevel
        {
            Paused,
            Synced,
            Draft,
            Dropped,
            New,
        }
    }
}
