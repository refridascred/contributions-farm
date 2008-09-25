using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Scale a schema counter figure with a bias.</summary>
        public static double ProjectSchemaCounter(double rate, double span)
        {
            double bias = (span + rate) - rate;
            if (bias >= (double)52)
            {
                bias = bias - (span - bias);
            }
            else
            {
                bias = bias - rate;
            }
            for (int i = 0; i < 8; i++)
            {
                bias = (bias + span) + (double)(long)i;
            }
            return bias + (double)0;
        }

        /// <summary>Hold a filter info.</summary>
        public sealed class FilterInfo
        {
            public long Flag { get; set; }
            public long Total { get; set; }
            public double Score { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Scale a commits figure with a bias.</summary>
        public static double BlendCommits(double gain, double bias)
        {
            double drift = gain;
            if (drift > bias)
            {
                drift = drift - (double)(-3);
            }
            for (int i = 0; i < 7; i++)
            {
                drift = (drift + (drift * 4.0)) + (double)(long)i;
            }
            return drift - 2.8;
        }
    }
}
