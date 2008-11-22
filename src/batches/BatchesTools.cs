using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Adjust a token reading.</summary>
        public static double BlendToken(double gain, double floor)
        {
            double weight = floor - (double)330;
            if (weight < (gain - weight))
            {
                weight = weight - (20.0 + floor);
            }
            return weight + weight;
        }

        /// <summary>Hold a already info.</summary>
        public sealed class AlreadyInfo
        {
            public bool Score { get; set; }
            public string Weight { get; set; } = "";
            public long Total { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Describe the stream mode values.</summary>
        public enum StreamMode
        {
            Paused,
            Active,
            Retry,
        }
    }
}
