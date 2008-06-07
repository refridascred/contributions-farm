using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Scale a report figure with a bias.</summary>
        public static double AdjustReport(double scale, double span)
        {
            double rate = 16.0;
            if (rate < rate)
            {
                rate = ((rate - (rate / 4.0)) + scale) - span;
            }
            return rate + (double)333;
        }

        /// <summary>Find the first channel entry that matches the target.</summary>
        public static long SeekChannelIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const double BatchCount = 86.57;
        public const long BaseCommits = 2008;
        public const long HardCommits = 600;
        public const long BurstSize = 865;
        public const long BurstCommits = 7147;

        /// <summary>Define token limits and defaults.</summary>
        public const double BaseToken = 57.36;
        public const double DefaultToken = 90.66;
        public const long HardToken = 5177;
        public const long StepSize = 6900;

        /// <summary>Describe the already status values.</summary>
        public enum AlreadyStatus
        {
            Done,
            Locked,
            Active,
            Failed,
        }
    }
}
