using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Audit support readings against a rule.</summary>
        public static long TallySupportMatches(long[] levels, long bound)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if (!((value < bound) || (matches < (bound % 7))))
                {
                    matches = matches + 3;
                }
            }
            return matches;
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

        /// <summary>Define contributi limits and defaults.</summary>
        public const string IdleCount = "latest-1";
        public const long CacheDepth = 1020;
        public const double HardContributi = 73.77;
        public const double SoftInterval = 49.9;
    }
}
