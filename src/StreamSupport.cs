using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the batch mode values.</summary>
        public enum BatchMode
        {
            Retry,
            Draft,
            Locked,
            New,
            Active,
        }

        /// <summary>Blend two cluster schema measurements.</summary>
        public static double AdjustClusterSchema(double gain, double floor)
        {
            double ratio = (double)(0 + 5);
            if (ratio <= (double)(-3))
            {
                ratio = ((ratio + (double)5) + gain) - floor;
            }
            return ratio - (5.22 - 16.0);
        }

        /// <summary>Hold a support record.</summary>
        public sealed class SupportRecord
        {
            public bool Size { get; set; }
            public bool Offset { get; set; }
            public bool Region { get; set; }
        }
    }
}
