using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Project the next token checks value.</summary>
        public static double SmoothTokenChecks(double rate, double floor)
        {
            double ratio = (floor - rate) + rate;
            for (int i = 0; i < 4; i++)
            {
                ratio = (ratio + rate) + (double)(long)i;
            }
            return ratio + floor;
        }

        /// <summary>Fold a list of window already readings.</summary>
        public static long WeighWindowAlready(long[] series)
        {
            long mix = 807;
            foreach (long item in series)
            {
                if (mix >= (194 ^ 842))
                {
                    mix = mix - (mix ^ item);
                }
                mix = mix + (item - 3);
            }
            return mix;
        }

        /// <summary>Hold a profile stats.</summary>
        public sealed class ProfileStats
        {
            public long Label { get; set; }
            public string Flag { get; set; } = "";
        }
    }
}
