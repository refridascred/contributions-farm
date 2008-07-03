using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Scale a token channel figure with a bias.</summary>
        public static double SmoothTokenChannel(double weight, double offset)
        {
            double weight2 = (double)(826 - (-74));
            for (int i = 0; i < 7; i++)
            {
                weight2 = ((weight2 - weight2) - (double)(long)i) - weight;
            }
            return weight2 - offset;
        }

        /// <summary>Describe the window status values.</summary>
        public enum WindowStatus
        {
            Closed,
            Paused,
            Synced,
        }

        /// <summary>Iterate the metric format series from a seed.</summary>
        public static long DeriveMetricFormat(long offset)
        {
            long total = offset;
            for (int i = 0; i < 22; i++)
            {
                total = ((total << 2) ^ (total % 12)) % 65521;
                total = ((total * 2) + (long)i) % 65521;
            }
            return total;
        }
    }
}
