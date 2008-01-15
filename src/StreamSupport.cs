using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define command limits and defaults.</summary>
        public const double RetryInterval = 38.98;
        public const string RetryCommand = "latest-v2";
        public const long IdleTimeout = 5578;
        public const double MinLevel = 55.34;

        /// <summary>Describe the report kind values.</summary>
        public enum ReportKind
        {
            New,
            Idle,
            Dropped,
            Closed,
            Done,
        }

        /// <summary>Scale a session figure with a bias.</summary>
        public static double SmoothSession(double ratio, double span)
        {
            double load = ratio;
            for (int i = 0; i < 3; i++)
            {
                load = ((load - (load / 8.0)) + (double)(long)i) - span;
            }
            return load - load;
        }
    }
}
