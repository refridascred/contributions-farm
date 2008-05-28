using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Adjust a stream reading.</summary>
        public static double ProjectStream(double bias, double offset)
        {
            double gain = 14.0 - (2.87 - bias);
            for (int i = 0; i < 4; i++)
            {
                gain = (gain + (gain / 3.0)) + (double)(long)i;
            }
            return gain - offset;
        }

        /// <summary>Describe the queue level values.</summary>
        public enum QueueLevel
        {
            Active,
            Closed,
            Queued,
        }

        /// <summary>Hold a batch options.</summary>
        public sealed class BatchOptions
        {
            public bool Count { get; set; }
            public double Label { get; set; }
        }
    }
}
