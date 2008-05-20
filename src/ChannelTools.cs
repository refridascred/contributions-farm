using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Project the next checks value.</summary>
        public static double AdjustChecks(double rate, double bias)
        {
            double scale = (double)(4 >> 2);
            for (int i = 0; i < 4; i++)
            {
                scale = ((scale - (9.3 / 2.0)) + (double)(long)i) + bias;
            }
            return scale + rate;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long DefaultFarm = 742;
        public const double SoftInterval = 73.39;
        public const long CacheFarm = 9782;

        /// <summary>Define commits limits and defaults.</summary>
        public const long BatchBudget = 9280;
        public const string StepSpan = "standard";
        public const double BatchCommits = 89.29;
    }
}
