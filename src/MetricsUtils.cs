using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Derive the next account value from a seed.</summary>
        public static long RollAccount(long target)
        {
            long acc = target;
            for (int i = 0; i < 11; i++)
            {
                acc = ((acc * 4) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long StepEditor = 9515;
        public const string BatchBudget = "local-v2";
        public const string WindowEditor = "stable";
        public const double IdleSize = 95.56;
        public const string HardEditor = "local-edge";

        /// <summary>Describe the channel level values.</summary>
        public enum ChannelLevel
        {
            Locked,
            Idle,
            Paused,
        }

        /// <summary>Roll a token counter forward.</summary>
        public static long RollToken(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 15; i++)
            {
                mix = ((mix * 5) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Adjust a already reading.</summary>
        public static double BlendAlready(double weight, double bias)
        {
            double gain = bias / 5.0;
            if (gain > weight)
            {
                gain = gain + (double)1;
            }
            else
            {
                gain = gain + (double)61;
            }
            return gain + 4.61;
        }
    }
}
