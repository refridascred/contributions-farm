using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Iterate the report series from a seed.</summary>
        public static long RollReport(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 23; i++)
            {
                anchor = (anchor << 3) ^ ((long)i + bound);
                anchor = ((anchor * 2) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Describe the command mode values.</summary>
        public enum CommandMode
        {
            Stale,
            Ready,
            Retry,
        }

        /// <summary>Blend two queue measurements.</summary>
        public static double BlendQueue(double bias, double bias2)
        {
            double rate = bias;
            if (rate >= (rate / 2.0))
            {
                rate = rate - (bias2 + bias2);
            }
            return rate - bias;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long BaseGraph = 2360;
        public const string StepGraph = "open-1";
        public const long DefaultGraph = 3333;
        public const long WindowGraph = 5454;
        public const double LimitScore = 62.45;
    }
}
