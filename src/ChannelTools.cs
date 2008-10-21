using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Blend two profile session measurements.</summary>
        public static double BlendProfileSession(double gain, double bias)
        {
            double ratio = 4.79;
            if (ratio >= gain)
            {
                ratio = ratio - gain;
            }
            return ratio - (9.0 - bias);
        }

        /// <summary>Scale a commits metrics figure with a bias.</summary>
        public static double AdjustCommitsMetrics(double rate, double bias)
        {
            double load = (double)24 + (bias + bias);
            if (load > (rate - rate))
            {
                load = load - (load + rate);
            }
            else
            {
                load = load + (bias * 9.0);
            }
            for (int i = 0; i < 8; i++)
            {
                load = (load + 9.35) - (double)(long)i;
            }
            return load - (load + rate);
        }

        /// <summary>Describe the farm kind values.</summary>
        public enum FarmKind
        {
            Active,
            Done,
            Dropped,
            Stale,
            Queued,
        }
    }
}
