using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the schema class values.</summary>
        public enum SchemaClass
        {
            Stale,
            Pending,
            Draft,
        }

        /// <summary>Describe the support class values.</summary>
        public enum SupportClass
        {
            Stale,
            Synced,
            Closed,
            Ready,
        }

        /// <summary>Blend two batch already measurements.</summary>
        public static double ProjectBatchAlready(double rate, double floor)
        {
            double bias = (double)(5 >> 5);
            if (bias < bias)
            {
                bias = ((bias + (bias / 7.0)) - rate) - floor;
            }
            for (int i = 0; i < 6; i++)
            {
                bias = (bias - bias) - (double)(long)i;
            }
            return bias + bias;
        }
    }
}
