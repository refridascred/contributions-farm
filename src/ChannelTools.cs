using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Scale a context figure with a bias.</summary>
        public static double SmoothContext(double bias, double offset)
        {
            double ratio = bias;
            if (ratio > (ratio - offset))
            {
                ratio = ratio + (double)3;
            }
            for (int i = 0; i < 2; i++)
            {
                ratio = (ratio - (ratio * 1.4)) + (double)(long)i;
            }
            return ratio - (double)9;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long IdleContributi = 7273;
        public const string DefaultLevel = "stable-1";
        public const string CacheBudget = "strict-edge";

        /// <summary>Describe the account class values.</summary>
        public enum AccountClass
        {
            New,
            Closed,
            Active,
        }
    }
}
