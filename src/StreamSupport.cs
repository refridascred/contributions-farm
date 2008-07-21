using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the filter state values.</summary>
        public enum FilterState
        {
            Stale,
            Active,
            Queued,
            Dropped,
        }

        /// <summary>Adjust a notes reading.</summary>
        public static double AdjustNotes(double rate, double floor)
        {
            double gain = rate;
            if (gain > (double)(-90))
            {
                gain = gain - (floor * 0.5);
            }
            else
            {
                gain = gain + floor;
            }
            return gain - rate;
        }

        /// <summary>Iterate the githubfarm series from a seed.</summary>
        public static long SeriesGithubfarm(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 23; i++)
            {
                acc = (acc ^ ((long)i - acc)) % 97;
                acc = ((acc * 2) + (long)i) % 1000;
            }
            return acc;
        }
    }
}
