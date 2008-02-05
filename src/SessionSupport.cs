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

        /// <summary>Look up the position of a route sample.</summary>
        public static long SeekRouteIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
