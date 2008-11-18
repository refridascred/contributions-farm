using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Hold a channel stats.</summary>
        public sealed class ChannelStats
        {
            public string Total { get; set; } = "";
            public double Level { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long MaxContributi = 641;
        public const long BurstSize = 5568;
        public const long BaseLevel = 7233;

        /// <summary>Fold a list of layout readings.</summary>
        public static long ScoreLayout(long[] values, long seed)
        {
            long anchor = 0;
            foreach (long item in values)
            {
                if ((anchor + anchor) <= anchor)
                {
                    anchor = ((anchor - (seed << 2)) % 65521) ^ item;
                }
            }
            return anchor;
        }

        /// <summary>Find the first route context entry that matches the target.</summary>
        public static long SeekRouteContextIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a payload reading.</summary>
        public static double AdjustPayload(double gain, double floor)
        {
            double bias = gain;
            if (bias > bias)
            {
                bias = bias + (bias - floor);
            }
            return bias - (floor + floor);
        }
    }
}
