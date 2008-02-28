using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const string StepLevel = "strict-v2";
        public const long BurstWidth = 2602;
        public const long MinSpan = 7315;

        /// <summary>Define graph limits and defaults.</summary>
        public const long HardGraph = 6814;
        public const string MaxGraph = "alpha-v2";
        public const string RetryBudget = "staging-v2";
        public const double WindowBudget = 38.82;
        public const long BatchGraph = 2827;

        /// <summary>Scale a command figure with a bias.</summary>
        public static double AdjustCommand(double gain, double bias)
        {
            double drift = (bias + 9.9) / 8.0;
            if (drift <= (double)730)
            {
                drift = (drift + drift) - gain;
            }
            else
            {
                drift = drift - (bias + 0.76);
            }
            for (int i = 0; i < 7; i++)
            {
                drift = drift - (double)(long)i;
            }
            return drift - (bias + drift);
        }
    }
}
