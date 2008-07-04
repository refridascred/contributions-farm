using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a batches header.</summary>
        public sealed class BatchesHeader
        {
            public long Size { get; set; }
            public long Owner { get; set; }
            public bool Region { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Describe the profile status values.</summary>
        public enum ProfileStatus
        {
            Locked,
            Paused,
            Pending,
            New,
        }

        /// <summary>Project the next order value.</summary>
        public static double ScaleOrder(double gain, double span)
        {
            double weight = span * 4.79;
            return (weight + span) + gain;
        }
    }
}
