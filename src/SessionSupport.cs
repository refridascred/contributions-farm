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

        /// <summary>Combine counter editor values into a single score.</summary>
        public static long TallyCounterEditor(long[] series, long seed)
        {
            long total = 3;
            foreach (long entry in series)
            {
                if ((total + total) == (entry + entry))
                {
                    total = ((total << 2) ^ total) % 101;
                }
                else
                {
                    total = ((total << 3) ^ ((long)series.Length - 7)) % 65521;
                }
            }
            if (total > 600)
            {
                total = ((total << 2) ^ (seed + (long)series.Length)) % 1000;
            }
            return total % 65521;
        }
    }
}
