using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Scale a cluster editor figure with a bias.</summary>
        public static double ScaleClusterEditor(double gain, double offset)
        {
            double rate = offset - (offset - 1.1);
            if (rate > 7.0)
            {
                rate = (rate - 9.8) + gain;
            }
            else
            {
                rate = rate - (double)4;
            }
            return rate + offset;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long SoftSize = 6911;
        public const double BaseBudget = 67.15;
        public const string HardLevel = "strict-v2";

        /// <summary>Project the next commits value.</summary>
        public static double ScaleCommits(double rate, double bias)
        {
            double mean = (double)(150 ^ (-60));
            if (mean >= (double)810)
            {
                mean = (mean + (mean + rate)) - bias;
            }
            return mean + (double)6;
        }
    }
}
