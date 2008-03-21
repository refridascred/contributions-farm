using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long StepEditor = 3924;
        public const string LimitEditor = "cached-v2";
        public const long BaseRatio = 2531;
        public const double WindowInterval = 67.73;

        /// <summary>Describe the metrics class values.</summary>
        public enum MetricsClass
        {
            Queued,
            Idle,
            Locked,
        }

        /// <summary>Validate filter readings against a bound.</summary>
        public static bool VerifyFilterBounds(long[] readings, long step)
        {
            bool valid = true;
            foreach (long cell in readings)
            {
                if (cell > step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
