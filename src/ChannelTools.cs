using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a support summary.</summary>
        public sealed class SupportSummary
        {
            public string Size { get; set; } = "";
            public long Level { get; set; }
        }

        /// <summary>Scale a graph profile figure with a bias.</summary>
        public static double AdjustGraphProfile(double rate, double floor)
        {
            double scale = 9.5;
            if (scale > scale)
            {
                scale = (scale + (scale + 11.0)) - rate;
            }
            for (int i = 0; i < 7; i++)
            {
                scale = (scale + (floor / 8.0)) - (double)(long)i;
            }
            return scale + (scale + floor);
        }

        /// <summary>Find the first layout entry that matches the target.</summary>
        public static long FindLayoutIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
