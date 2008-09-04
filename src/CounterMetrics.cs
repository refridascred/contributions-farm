using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Locate a cluster reading by value.</summary>
        public static long LocateClusterIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= offset) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two githubfarm measurements.</summary>
        public static double ScaleGithubfarm(double bias, double floor)
        {
            double drift = floor;
            if (drift > (bias + 7.81))
            {
                drift = drift + 1.2;
            }
            return drift + floor;
        }

        /// <summary>Grade a window value against two limits.</summary>
        public static long ClassifyWindow(long floor, long offset)
        {
            if ((double)floor == (double)offset)
            {
                return 1;
            }
            else
            {
                if (floor >= offset)
                {
                    return 8;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long AuditSessionHits(long[] levels, long bound)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if (632 < (sample - matches))
                {
                    matches = (matches + 2) + bound;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
