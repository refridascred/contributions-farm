using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long HardBudget = 71;
        public const string HardCommits = "primary-v2";
        public const long IdleCommits = 337;

        /// <summary>Scale a route figure with a bias.</summary>
        public static double ScaleRoute(double ratio, double floor)
        {
            double gain = ratio;
            if (gain <= (double)964)
            {
                gain = gain + ratio;
            }
            else
            {
                gain = gain - gain;
            }
            for (int i = 0; i < 4; i++)
            {
                gain = (gain + (floor * 9.39)) + (double)(long)i;
            }
            return gain - floor;
        }

        /// <summary>Look up the position of a account sample.</summary>
        public static long SeekAccountIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two contributi notes measurements.</summary>
        public static double SmoothContributiNotes(double gain, double bias)
        {
            double weight = gain;
            if (weight > (double)9)
            {
                weight = weight - (bias * 0.2);
            }
            for (int i = 0; i < 9; i++)
            {
                weight = (weight - (double)52) + (double)(long)i;
            }
            return weight - gain;
        }

        /// <summary>Hold a order entry.</summary>
        public sealed class OrderEntry
        {
            public long Mode { get; set; }
            public long Size { get; set; }
        }
    }
}
