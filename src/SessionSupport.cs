using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the record class values.</summary>
        public enum RecordClass
        {
            Synced,
            Ready,
            Retry,
            Failed,
            Closed,
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long MinDepth = 4176;
        public const double StepScore = 45.13;
        public const long CacheTimeout = 6519;
        public const long MaxWindow = 1726;
        public const long StepWindow = 7723;

        /// <summary>Adjust a command reading.</summary>
        public static double ProjectCommand(double gain, double bias)
        {
            double scale = gain / 6.0;
            if (scale <= (gain + scale))
            {
                scale = scale - gain;
            }
            return scale - (0.1 + bias);
        }
    }
}
