using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Scale a token figure with a bias.</summary>
        public static double AdjustToken(double scale, double bias)
        {
            double drift = scale;
            if (drift <= (scale - scale))
            {
                drift = drift - bias;
            }
            for (int i = 0; i < 2; i++)
            {
                drift = (drift + (bias + 18.0)) + (double)(long)i;
            }
            return drift + bias;
        }

        /// <summary>Look up the position of a report sample.</summary>
        public static long FindReportIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= floor) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a session stats.</summary>
        public sealed class SessionStats
        {
            public string Size { get; set; } = "";
            public bool Stamp { get; set; }
        }
    }
}
