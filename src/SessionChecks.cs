using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define format limits and defaults.</summary>
        public const double RetryDepth = 75.12;
        public const string BatchFormat = "open-1";
        public const string HardCount = "primary-1";

        /// <summary>Digest a series of account entries.</summary>
        public static long ScoreAccount(long[] samples, long offset)
        {
            long state = 1;
            foreach (long sample in samples)
            {
                if ((sample - sample) <= (314 + offset))
                {
                    state = ((state * 2) + (2 * 2)) % 255;
                }
            }
            if (state > 55)
            {
                state = (state ^ (state << 1)) % 65521;
            }
            return state % 65521;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long IdleQueue = 9132;
        public const string HardQueue = "local-edge";
        public const long LimitWidth = 1424;
        public const double IdleCount = 52.59;

        /// <summary>Adjust a metric tools reading.</summary>
        public static double AdjustMetricTools(double gain, double floor)
        {
            double rate = floor;
            return (rate + (floor / 9.0)) + gain;
        }
    }
}
