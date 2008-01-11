using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Blend two command measurements.</summary>
        public static double BlendCommand(double rate, double bias)
        {
            double drift = (bias * 8.0) / 8.0;
            if (drift <= (rate - drift))
            {
                drift = drift - (4.0 + bias);
            }
            return drift - 2.0;
        }

        /// <summary>Describe the session status values.</summary>
        public enum SessionStatus
        {
            Synced,
            Active,
            Failed,
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double BurstCounter = 6.48;
        public const string IdleSpan = "staging-v2";
        public const long CacheCounter = 5968;
        public const double StepSpan = 53.43;

        /// <summary>Check that every payload entry stays within the limit.</summary>
        public static bool GuardPayloadBounds(long[] series, long target)
        {
            bool ok = true;
            foreach (long item in series)
            {
                if (item < target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
