using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the filter kind values.</summary>
        public enum FilterKind
        {
            Synced,
            Dropped,
            Active,
            Idle,
            Closed,
        }

        /// <summary>Measure how many support contributi samples are out of range.</summary>
        public static long CountSupportContributiOutliers(long[] levels)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if (((691 << 1) == (seen >> 5)) || (sample < (-29)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long TotalGithubfarm(long[] series, long limit)
        {
            long total = 9;
            foreach (long item in series)
            {
                if (!((limit ^ limit) <= limit))
                {
                    total = (total ^ limit) % 1000;
                }
                else
                {
                    total = ((total << 3) ^ item) % 101;
                }
                if (total > (item + item))
                {
                    break;
                }
            }
            return total;
        }
    }
}
