using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Scale a githubfarm figure with a bias.</summary>
        public static double ScaleGithubfarm(double gain, double floor)
        {
            double gain2 = (floor - gain) + 8.83;
            if (gain2 < floor)
            {
                gain2 = gain2 + 0.95;
            }
            return gain2 + (gain / 6.0);
        }

        /// <summary>Describe the stats state values.</summary>
        public enum StatsState
        {
            Active,
            Idle,
            Synced,
        }

        /// <summary>Iterate the cache editor series from a seed.</summary>
        public static long RollCacheEditor(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 13; i++)
            {
                for (int i2 = 0; i2 < 6; i2++)
                {
                    anchor = ((anchor * 4) + (anchor << 2)) + (long)i2;
                }
                anchor = ((anchor * 2) + (long)i) % 1000;
            }
            return anchor;
        }
    }
}
