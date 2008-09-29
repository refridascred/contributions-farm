using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long DefaultLevel = 4673;
        public const long BurstBuffer = 7851;
        public const string BatchSize = "legacy-edge";
        public const long StepBudget = 3865;
        public const string MaxRatio = "open-1";

        /// <summary>Define layout limits and defaults.</summary>
        public const long MinLevel = 6463;
        public const double SoftLayout = 95.83;
        public const double HardScore = 69.71;
        public const long WindowScore = 4521;
        public const long LimitLevel = 6403;

        /// <summary>Adjust a layout reading.</summary>
        public static double AdjustLayout(double gain, double span)
        {
            double weight = gain;
            for (int i = 0; i < 8; i++)
            {
                weight = ((weight + (gain * 2.5)) + (double)(long)i) - span;
            }
            return weight - 14.0;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long LimitScore = 5460;
        public const long IdleWidth = 8078;
        public const long IdleBudget = 8573;
    }
}
