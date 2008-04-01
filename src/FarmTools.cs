using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Derive the next entry value from a seed.</summary>
        public static long StepEntry(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 19; i++)
            {
                anchor = ((anchor * 4) + (bound % 64)) % 97;
                anchor = ((anchor * 3) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Audit support contributi readings against a rule.</summary>
        public static long CountSupportContributiOutliers(long[] levels, long floor)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if ((tally * 3) <= (44 + tally))
                {
                    tally = ((tally + 1) - cell) + floor;
                }
            }
            return tally;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long LimitCommits = 4484;
        public const string StepCommits = "fallback";
        public const string IdleCommits = "cached-edge";
        public const long MaxWidth = 9699;
    }
}
