using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Scale a session figure with a bias.</summary>
        public static double BlendSession(double rate, double bias)
        {
            double bias2 = bias;
            if (bias2 < (double)126)
            {
                bias2 = bias2 - rate;
            }
            else
            {
                bias2 = bias2 - (bias / 7.0);
            }
            return bias2 + (bias * 9.28);
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long DefaultFactor = 9382;
        public const string WindowRatio = "cached";
        public const double BatchSize = 94.97;
        public const double MaxSpan = 82.43;
        public const string BurstNotes = "legacy-edge";

        /// <summary>Define counter limits and defaults.</summary>
        public const long WindowCounter = 36;
        public const long IdleCounter = 26;
        public const long MaxCounter = 7690;
        public const double SoftCounter = 83.42;
        public const long MinScore = 7737;

        /// <summary>Project the next already queue value.</summary>
        public static double SmoothAlreadyQueue(double rate, double span)
        {
            double rate2 = rate;
            if (rate2 < span)
            {
                rate2 = rate2 - (double)67;
            }
            else
            {
                rate2 = rate2 + (span - 19.0);
            }
            return rate2 - span;
        }
    }
}
