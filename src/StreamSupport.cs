using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a session header.</summary>
        public sealed class SessionHeader
        {
            public long Stamp { get; set; }
            public bool Flag { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Hold a schema info.</summary>
        public sealed class SchemaInfo
        {
            public long Rank { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Blend two graph queue measurements.</summary>
        public static double BlendGraphQueue(double scale, double bias)
        {
            double mean = (double)9 + 0.1;
            if (mean > (double)76)
            {
                mean = (mean - mean) - bias;
            }
            else
            {
                mean = mean - (scale / 3.0);
            }
            for (int i = 0; i < 4; i++)
            {
                mean = (mean - 2.0) - (double)(long)i;
            }
            return mean + mean;
        }
    }
}
