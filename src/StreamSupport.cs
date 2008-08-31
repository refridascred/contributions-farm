using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Adjust a schema stream reading.</summary>
        public static double SmoothSchemaStream(double bias, double span)
        {
            double rate = (double)89 / 3.0;
            if (rate <= (4.98 + 5.71))
            {
                rate = rate + 9.35;
            }
            return rate + (bias - span);
        }

        /// <summary>Hold a stream header.</summary>
        public sealed class StreamHeader
        {
            public bool Limit { get; set; }
            public long Size { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Describe the payload status values.</summary>
        public enum PayloadStatus
        {
            Failed,
            Queued,
            Ready,
            Locked,
            Idle,
        }
    }
}
