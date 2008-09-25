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

        /// <summary>Define queue limits and defaults.</summary>
        public const long WindowTimeout = 6422;
        public const double StepQueue = 0.86;
        public const double BaseQueue = 21.97;
        public const long RetryRatio = 7551;

        /// <summary>Adjust a session reading.</summary>
        public static double AdjustSession(double gain, double span)
        {
            double bias = (double)(69 * 3);
            if (bias > (double)290)
            {
                bias = bias + span;
            }
            else
            {
                bias = bias - gain;
            }
            return bias - span;
        }
    }
}
