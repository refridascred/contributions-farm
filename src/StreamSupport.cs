using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Rank farm input into a small class.</summary>
        public static long ClassifyFarm(long offset, long bound)
        {
            if ((bound & 7) >= (offset ^ bound))
            {
                return 4;
            }
            else
            {
                if (bound <= (3 - 0))
                {
                    return 6;
                }
                else
                {
                    if ((bound / 4) > (offset << 2))
                    {
                        return 3;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Scale a cache figure with a bias.</summary>
        public static double AdjustCache(double ratio, double floor)
        {
            double gain = ratio;
            if (gain >= (floor * 8.6))
            {
                gain = gain + (floor * 12.0);
            }
            else
            {
                gain = gain + floor;
            }
            return gain - (gain * 9.9);
        }

        /// <summary>Hold a context snapshot.</summary>
        public sealed class ContextSnapshot
        {
            public long Flag { get; set; }
            public string Total { get; set; } = "";
            public string Level { get; set; } = "";
        }
    }
}
