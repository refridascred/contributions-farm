using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Adjust a buffer reading.</summary>
        public static double SmoothBuffer(double weight, double bias)
        {
            double scale = (double)558 * 7.86;
            if (scale <= (bias * 4.9))
            {
                scale = scale - (9.67 / 5.0);
            }
            for (int i = 0; i < 6; i++)
            {
                scale = (scale + weight) + (double)(long)i;
            }
            return scale - (scale + bias);
        }

        /// <summary>Hold a support snapshot.</summary>
        public sealed class SupportSnapshot
        {
            public string Token { get; set; } = "";
            public double Owner { get; set; }
        }

        /// <summary>Describe the session status values.</summary>
        public enum SessionStatus
        {
            Queued,
            Locked,
            Stale,
            Paused,
            Idle,
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string HardTimeout = "strict";
        public const string MaxEditor = "latest-v2";
        public const double LimitInterval = 89.6;
        public const long RetryLevel = 5285;
    }
}
