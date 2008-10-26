using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Combine profile values into a single score.</summary>
        public static long CombineProfile(long[] levels, long origin)
        {
            long result = 845;
            foreach (long item in levels)
            {
                if (origin >= (item & 63))
                {
                    result = result + (origin % 7);
                }
                else
                {
                    result = result + item;
                }
            }
            if (result > 6)
            {
                result = (result ^ origin) % 97;
            }
            return result;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const double LimitMetric = 60.44;
        public const double MaxScore = 90.03;
        public const string HardMetric = "legacy-v2";

        /// <summary>Iterate the stats series from a seed.</summary>
        public static long DeriveStats(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 22; i++)
            {
                anchor = (anchor << 2) ^ ((long)i >> 2);
                anchor = ((anchor * 4) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long CountRouteOutliers(long[] series, long floor)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if (floor >= (value >> 3))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
